
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BepInEx;
using Eremite.Model.Sound;
using UnityEngine;
using UnityEngine.Networking;

namespace ATS_API.Helpers;

public static class AudioHelpers
{
    public static Dictionary<string, AudioType> AudioTypes = new Dictionary<string, AudioType>()
    {
        { ".mp3", AudioType.MPEG },
        { ".wav", AudioType.WAV },
        { ".ogg", AudioType.OGGVORBIS },
        { ".aiff", AudioType.AIFF }, // WHO USES AIFF.
        { ".aif", AudioType.AIFF } // I'M UNSURE IF I SHOULD EVEN INCLUDE AIFF. WHO USES AIFF.
    };
    
    public static SoundModel ToSoundModel(this AudioClip clip, float volume=1f, float pitch=1f, float randomVolume=0f, float randomPitch=0.04f, int maxSoundsInOnePlace=3, int weight=1, bool stopOnPause=false)
    {
        SoundModel soundModel = new SoundModel();
        soundModel.audioClip = clip;
        soundModel.volume = volume;
        soundModel.pitch = pitch;
        soundModel.randomVolume = randomVolume;
        soundModel.randomPitch = randomPitch;
        soundModel.maxSoundsInOnePlace = maxSoundsInOnePlace;
        soundModel.weight = weight;
        soundModel.stopOnPause = stopOnPause;
        return soundModel;
    }
    
    internal static string GetAudioPath(string filename)
    {
        string[] files = Directory.GetFiles(Paths.PluginPath, filename, SearchOption.AllDirectories);
        return files.FirstOrDefault();
    }

    internal static AudioType GetAudioType(string filename)
    {
        string extension = Path.GetExtension(filename)?.ToLower();
        return AudioTypes.ContainsKey(extension ?? "") ? AudioTypes[extension] : AudioType.UNKNOWN;
    }
    
    /// <summary>
    /// A helper method for converting an audio file into an Unity <c>AudioClip</c>.
    /// </summary>
    /// <param name="guid">Your plugin's GUID.</param>
    /// <param name="path">The path to your audio file.</param>
    /// <returns>The audio file converted into an <c>AudioClip</c> object.</returns>
    public static AudioClip LoadAudioClip(string guid, string path)
    {
        if (!Path.IsPathRooted(path))
        {
            path = GetAudioPath(path);
        }

        string filename = Path.GetFileName(path);
        AudioType audioType = GetAudioType(path);

        if (audioType == AudioType.UNKNOWN)
        {
            Plugin.Log.LogError($"Couldn't load file {filename ?? "(null)"} as AudioClip. AudioType is unknown.");
            return null;
        }

        return LoadAudioClip_Sync(path, audioType, guid);
    }
    
    /// <summary>
    /// A helper method for converting an audio file into an Unity <c>AudioClip</c>.
    /// </summary>
    /// <param name="path">The path to your audio file.</param>
    /// <returns>The audio file converted into an <c>AudioClip</c> object.</returns>
    public static AudioClip LoadAudioClip(string path)
    {
        return LoadAudioClip(string.Empty, path);
    }
    
    private static AudioClip LoadAudioClip_Sync(string path, AudioType audioType, string guid = null)
    {
        guid ??= string.Empty;
        string filename = Path.GetFileName(path);

        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(path, audioType))
        {
            www.SendWebRequest();
            while (!www.isDone) 
                continue;

            if (www.isNetworkError || www.isHttpError)
            {
                Plugin.Log.LogError($"Couldn't load file \'{filename ?? "(null)"}\' as AudioClip!");
                Plugin.Log.LogError(www.error);
                return null;
            }
            else
            {
                AudioClip audioClip = DownloadHandlerAudioClip.GetContent(www);
                if (audioClip != null)
                {
                    // Plugin.Log.LogInfo($"Loaded \'{filename}\' as AudioClip. AudioType: {audioType}");
                    audioClip.name = $"{guid}_{filename}";
                }
                return audioClip;
            }
        }
    }
    
    public static string ExportAudioClip(AudioClip clip, string path)
    {
        string directory = Path.GetDirectoryName(path);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        
        using (var fileStream = CreateEmpty(path)) {

	        ConvertAndWrite(fileStream, clip);

	        WriteHeader(fileStream, clip);
        }
 
        return path;
    }
    
    private static FileStream CreateEmpty(string filepath) {
	    var fileStream = new FileStream(filepath, FileMode.Create);
	    byte emptyByte = new byte();

	    for(int i = 0; i < 44; i++) //preparing the header
	    {
		    fileStream.WriteByte(emptyByte);
	    }

	    return fileStream;
    }
    
    private static void ConvertAndWrite(FileStream fileStream, AudioClip clip) {
		var samples = new float[clip.samples];
		clip.GetData(samples, 0);

		Int16[] intData = new Int16[samples.Length];
		//converting in 2 float[] steps to Int16[], //then Int16[] to Byte[]

		Byte[] bytesData = new Byte[samples.Length * 2];
		//bytesData array is twice the size of
		//dataSource array because a float converted in Int16 is 2 bytes.

		int rescaleFactor = 32767; //to convert float to Int16

		for (int i = 0; i<samples.Length; i++) {
			intData[i] = (short) (samples[i] * rescaleFactor);
			Byte[] byteArr = new Byte[2];
			byteArr = BitConverter.GetBytes(intData[i]);
			byteArr.CopyTo(bytesData, i * 2);
		}

		fileStream.Write(bytesData, 0, bytesData.Length);
	}

	private static void WriteHeader(FileStream fileStream, AudioClip clip) {
		var hz = clip.frequency;
		var channels = clip.channels;
		var samples = clip.samples;

		fileStream.Seek(0, SeekOrigin.Begin);

		Byte[] riff = System.Text.Encoding.UTF8.GetBytes("RIFF");
		fileStream.Write(riff, 0, 4);

		Byte[] chunkSize = BitConverter.GetBytes(fileStream.Length - 8);
		fileStream.Write(chunkSize, 0, 4);

		Byte[] wave = System.Text.Encoding.UTF8.GetBytes("WAVE");
		fileStream.Write(wave, 0, 4);

		Byte[] fmt = System.Text.Encoding.UTF8.GetBytes("fmt ");
		fileStream.Write(fmt, 0, 4);

		Byte[] subChunk1 = BitConverter.GetBytes(16);
		fileStream.Write(subChunk1, 0, 4);

		UInt16 two = 2;
		UInt16 one = 1;

		Byte[] audioFormat = BitConverter.GetBytes(one);
		fileStream.Write(audioFormat, 0, 2);

		Byte[] numChannels = BitConverter.GetBytes(channels);
		fileStream.Write(numChannels, 0, 2);

		Byte[] sampleRate = BitConverter.GetBytes(hz);
		fileStream.Write(sampleRate, 0, 4);

		Byte[] byteRate = BitConverter.GetBytes(hz * channels * 2); // sampleRate * bytesPerSample*number of channels, here 44100*2*2
		fileStream.Write(byteRate, 0, 4);

		UInt16 blockAlign = (ushort) (channels * 2);
		fileStream.Write(BitConverter.GetBytes(blockAlign), 0, 2);

		UInt16 bps = 16;
		Byte[] bitsPerSample = BitConverter.GetBytes(bps);
		fileStream.Write(bitsPerSample, 0, 2);

		Byte[] datastring = System.Text.Encoding.UTF8.GetBytes("data");
		fileStream.Write(datastring, 0, 4);

		Byte[] subChunk2 = BitConverter.GetBytes(samples * channels * 2);
		fileStream.Write(subChunk2, 0, 4);
	}
}

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
}
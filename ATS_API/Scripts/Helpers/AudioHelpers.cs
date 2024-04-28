
using Eremite.Model.Sound;
using UnityEngine;

namespace ATS_API.Helpers;

public static class AudioHelpers
{
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
}
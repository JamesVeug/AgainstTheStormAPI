using System.Linq;
using ATS_API.Helpers;
using Eremite.Model.Sound;
using UnityEngine;

namespace ATS_API.Effects;

public partial class TraderBuilder
{
    public SoundRef AddOpenedSounds(params AudioClip[] sClip)
    {
        var soundModels = sClip.Select(a => a.ToSoundModel());
        ArrayExtensions.AddElements(ref m_traderModel.panelOpenedSound.sounds, soundModels);
        return m_traderModel.panelOpenedSound;
    }

    public SoundRef AddClosedSounds(params AudioClip[] sClip)
    {
        var soundModels = sClip.Select(a => a.ToSoundModel());
        ArrayExtensions.AddElements(ref m_traderModel.panelClosedSound.sounds, soundModels);
        return m_traderModel.panelClosedSound;
    }

    public SoundRef AddTransactionSounds(params AudioClip[] sClip)
    {
        var soundModels = sClip.Select(a => a.ToSoundModel());
        ArrayExtensions.AddElements(ref m_traderModel.transactionSound.sounds, soundModels);
        return m_traderModel.transactionSound;
    }

    public SoundRef AddArrivalSounds(params AudioClip[] sClip)
    {
        var soundModels = sClip.Select(a => a.ToSoundModel());
        ArrayExtensions.AddElements(ref m_traderModel.arrivalSound.sounds, soundModels);
        return m_traderModel.arrivalSound;
    }

    public SoundRef AddDepartureSounds(params AudioClip[] sClip)
    {
        var soundModels = sClip.Select(a => a.ToSoundModel());
        ArrayExtensions.AddElements(ref m_traderModel.departureSound.sounds, soundModels);
        return m_traderModel.departureSound;
    }
}
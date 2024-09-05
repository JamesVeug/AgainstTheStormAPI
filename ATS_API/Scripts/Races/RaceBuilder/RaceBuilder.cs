using System;
using System.Linq;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Races;

public partial class RaceBuilder
{
    public string Name => newRaceData.RaceModel.name; // myguid_itemName
    public NewRaceData NewRaceData => newRaceData;
    
    private readonly string guid; // myGuid
    private readonly string name; // itemName
    
    private readonly NewRaceData newRaceData;

    public RaceBuilder(string guid, string name)
    {
        this.guid = guid;
        this.name = name;

        newRaceData = RaceManager.New(guid, name);
    }
    
    public RaceBuilder SetWalkSpeed(float speed)
    {
        newRaceData.RaceModel.baseSpeed = speed;
        return this;
    }
    
    public RaceBuilder SetHungerEffect(ResolveEffectTypes effect)
    {
        newRaceData.HungerEffect = effect;
        return this;
    }
}

namespace ATS_API.Races;


public partial class RaceBuilder
{
    public RaceBuilder SetResolveRange(float initial = 5, float min = 0, float max = 50)
    {
        newRaceData.RaceModel.initialResolve = initial;
        newRaceData.RaceModel.maxResolve = max;
        newRaceData.RaceModel.minResolve = min;
        return this;
    }

    public RaceBuilder SetResolveGain(float reputationPerSec = 0.000195f, float maxReputationFromResolvePerSec=0.025f,
        float resolveToReputationRatio=0.1f)
    {
        newRaceData.RaceModel.reputationPerSec = reputationPerSec;
        newRaceData.RaceModel.maxReputationFromResolvePerSec = maxReputationFromResolvePerSec;
        newRaceData.RaceModel.resolveToReputationRatio = resolveToReputationRatio;
        return this;
    }

    public RaceBuilder SetMinPopulationToGainResolve(int population)
    {
        newRaceData.RaceModel.minPopulationToGainReputation = population;
        return this;
    }
    
    // TODO: Methods for the other resolve related fields
}
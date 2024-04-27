using ATS_API.Helpers;
using Eremite.Model;

namespace ATS_API.Effects;

public class NewEffectData : ASyncable<EffectModel>
{
    public string Guid;
    public string Name;
    public EffectModel EffectModel;
    public Availability Availability = new Availability();
    public bool IsCornerstone = false;
    public int Chance = 10; // 1-100

    public override void Sync(EffectModel model)
    {
        
    }
}
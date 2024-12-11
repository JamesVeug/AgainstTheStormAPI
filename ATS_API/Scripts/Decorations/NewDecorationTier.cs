using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.Model;

namespace ATS_API.Decorations;

public class NewDecorationTier : ASyncable<DecorationTier>
{
    public DecorationTier Model;
    public DecorationTierTypes ID;
    public string Guid;
    public string RawName;
    
    public List<NameToAmount> RequiredResources;

    public override void PostSync()
    {
        base.PostSync();
        
        if (RequiredResources != null)
        {
            Model.referenceCost = RequiredResources.Select(a=> new GoodRef()
            {
                amount = a.Amount,
                good = a.Name.ToGoodModel()
            }).Where(a=>a.good != null).ToArray();
        }
        else if(Model.referenceCost == null)
        {
            Model.referenceCost = new GoodRef[0];
        }
    }
}
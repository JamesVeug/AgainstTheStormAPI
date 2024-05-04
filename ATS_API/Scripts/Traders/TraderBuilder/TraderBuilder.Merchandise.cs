using ATS_API.Helpers;
using ATS_API.Traders;
using Eremite.Model;

namespace ATS_API.Effects;

public partial class TraderBuilder
{
    public void SetMerchandise(params EffectDrop[] merch)
    {
        m_newData.Merchandise.Clear();
        foreach (EffectDrop drop in merch)
        {
            m_newData.Merchandise.Add(new NameToAmount(0, drop.reward.Name, (int)drop.chance));
        }
    }

    public void SetMerchandise(params NameToAmount[] merch)
    {
        m_newData.Merchandise.Clear();
        m_newData.Merchandise.AddRange(merch);
    }

    public void AddMerchandise(params EffectDrop[] merch)
    {
        foreach (EffectDrop drop in merch)
        {
            m_newData.Merchandise.Add(new NameToAmount(0, drop.reward.Name, (int)drop.chance));
        }
    }

    public void AddMerchandise(params NameToAmount[] merch)
    {
        m_newData.Merchandise.AddRange(merch);
    }

    public void AddDefaultMerchandise()
    {
        m_newData.Merchandise.AddRange(TraderHelpers.DefaultMerchandise);
    }
}
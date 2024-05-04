using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Traders;

namespace ATS_API.Effects;

public partial class TraderBuilder
{
    public void SetGuaranteedOfferedGoods(params NameToAmount[] goods)
    {
        m_newData.GuaranteedOfferedGoods = new List<NameToAmount>(goods);
    }

    public void AddDefaultGuaranteedOfferedGoods()
    {
        m_newData.GuaranteedOfferedGoods.AddRange(TraderHelpers.DefaultGuaranteedOfferedGoods);
    }

    public void AddGuaranteedOfferedGoods(params NameToAmount[] goods)
    {
        m_newData.GuaranteedOfferedGoods.AddRange(goods);
    }
}
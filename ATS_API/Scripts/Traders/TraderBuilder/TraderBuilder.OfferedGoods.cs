using System.Collections.Generic;
using ATS_API.Traders;

namespace ATS_API.Effects;

public partial class TraderBuilder
{
    public void SetOfferedGoods(params NameToAmount[] goods)
    {
        m_newData.OfferedGoods = new List<NameToAmount>(goods);
    }

    public void AddOfferedGoods(params NameToAmount[] goods)
    {
        m_newData.OfferedGoods.AddRange(goods);
    }

    public void AddDefaultOfferedGoods()
    {
        m_newData.OfferedGoods.AddRange(TraderHelpers.DefaultOfferedGoods);
    }
}
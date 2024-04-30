using System.Collections.Generic;

namespace ATS_API.Effects;

public partial class TraderBuilder
{
    public void SetDesiredGoods(params string[] goods)
    {
        m_newData.DesiredGoods = new List<string>(goods);
    }

    public void AddDesiredGoods(params string[] goods)
    {
        m_newData.DesiredGoods.AddRange(goods);
    }

    public void AddDefaultDesiredGoods()
    {
        m_newData.DesiredGoods.AddRange(TraderHelpers.DefaultDesiredGoods);
    }
}
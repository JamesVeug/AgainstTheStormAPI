using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;

namespace ATS_API.Effects;

public partial class TraderBuilder
{
    public void SetDesiredGoods(params string[] goods)
    {
        m_newData.DesiredGoods = new List<string>(goods);
    }
    
    public void SetDesiredGoods(params GoodsTypes[] goods)
    {
        m_newData.DesiredGoods = new List<string>(goods.Select(a=>a.ToName()));
    }

    public void AddDesiredGoods(params string[] goods)
    {
        m_newData.DesiredGoods.AddRange(goods);
    }

    public void AddDesiredGoods(params GoodsTypes[] goods)
    {
        m_newData.DesiredGoods.AddRange(goods.Select(a=>a.ToName()));
    }

    public void AddDefaultDesiredGoods()
    {
        m_newData.DesiredGoods.AddRange(TraderHelpers.DefaultDesiredGoods);
    }
}
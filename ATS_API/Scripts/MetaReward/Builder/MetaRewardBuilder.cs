using Eremite.Model.Meta;
using UnityEngine;

namespace ATS_API.MetaRewards;

public class MetaRewardBuilder<T> where T: MetaRewardModel
{
    public T Model => m_model;
    public NewMetaRewardData NewData => m_newData;
    
    protected readonly string m_guid;
    protected readonly string m_name;
    protected readonly NewMetaRewardData m_newData;
    protected readonly T m_model;
    
    public MetaRewardBuilder(string guid, string name)
    {
        m_guid = guid;
        m_name = name;
        m_newData = MetaRewardManager.New<T>(guid, name);
        m_model = m_newData.Model as T;
        m_model.label = ScriptableObject.CreateInstance<MetaRewardLabel>();
        m_model.label.color = Color.black;
        m_model.label.name = m_model.name + "_label";
    }

    protected MetaRewardBuilder(MetaRewardModel model)
    {
        m_model = model as T;
        m_newData = NewMetaRewardData.FromModel(model);
        m_guid = m_newData.guid;
        m_name = m_newData.rawName;
    }
}
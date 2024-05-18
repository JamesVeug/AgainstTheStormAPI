
using System.Collections.Generic;
using Eremite.Buildings;
using UnityEngine;

namespace ATS_API.Helpers;

public class RecipeBuilder<T> where T : RecipeModel
{
    private readonly Grade Grade;
    private readonly List<TagTypes> Tags = new List<TagTypes>();

    public RecipeBuilder(Grade grade)
    {
        Grade = grade;
    }

    public void AddTags(List<TagTypes> tags)
    {
        Tags.AddRange(tags);
    }
    
    public void AddTags(params TagTypes[] tags)
    {
        Tags.AddRange(tags);
    }
    
    public void SetTags(List<TagTypes> tags)
    {
        Tags.Clear();
        Tags.AddRange(tags);
    }
    
    public void SetTags(params TagTypes[] tags)
    {
        Tags.Clear();
        Tags.AddRange(tags);
    }
    
    /// <summary>
    /// Requires being run after HookMainControllerSetup() has been called. 
    /// </summary>
    public virtual T Build()
    {
        T t = ScriptableObject.CreateInstance<T>();
        t.grade = Grade.ToModel();
        t.tags = Tags.ToTagArray();

        return t;
    }
}
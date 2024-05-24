﻿
using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Buildings;
using UnityEngine;

namespace ATS_API.Recipes.Builders;

public class RecipeBuilder<T> where T : RecipeModel
{
    private readonly Grade Grade;
    private readonly List<TagTypes> Tags = new List<TagTypes>();

    public RecipeModel RecipeModel = null;
    private INewRecipeData m_newData;
    
    public RecipeBuilder(string guid, string name, Grade grade)
    {
        Grade = grade;
        m_newData = RecipeManager.CreateRecipe<T>(guid, name);
        RecipeModel = m_newData.RecipeModel;
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
        RecipeModel.grade = Grade.ToModel();
        RecipeModel.tags = Tags.ToModelTagArray();

        return RecipeModel as T;
    }
}
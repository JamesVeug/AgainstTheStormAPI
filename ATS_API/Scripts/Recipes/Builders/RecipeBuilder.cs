
using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Buildings;

namespace ATS_API.Recipes.Builders;

public class RecipeBuilder<T> where T : RecipeModel
{
    private readonly string guid; // myGuid
    private readonly string name; // itemName

    public RecipeModel RecipeModel = null;
    
    protected readonly List<TagTypes> Tags = new List<TagTypes>();
    protected Grade Grade;
    protected INewRecipeData m_newData;

    public RecipeBuilder()
    {
        
    }
    
    public RecipeBuilder(string guid, string name)
    {
        m_newData = RecipeManager.CreateRecipe<T>(guid, name);
        RecipeModel = m_newData.RecipeModel;
    }
    
    public RecipeBuilder(string guid, string name, Grade grade)
    {
        SetGrade(grade);
        m_newData = RecipeManager.CreateRecipe<T>(guid, name);
        RecipeModel = m_newData.RecipeModel;
    }
    
    public RecipeBuilder<T> SetGrade(Grade grade)
    {
        Grade = grade;
        return this;
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
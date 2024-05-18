using System;
using System.Collections.Generic;
using ATS_API.Effects;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;


namespace ATS_API.Buildings;

public class WorkshopBuildingBuilder : BuildingBuilder<WorkshopModel>
{
    public class MetaData
    {
        public string ProducedGood;
        public int ProducedAmount;
        public List<NameToAmount> RequiredGoods;
        public int ProductionTime;
        public Grade Grade;
        public List<WorkshopRecipeBuilder> Builders;
        public List<WorkshopRecipeModel> Recipes;
    }

    private MetaData metaData;
    
    public WorkshopBuildingBuilder(string guid, string name) : base(guid, name, BuildingBehaviourTypes.Workshop)
    {
        metaData = new MetaData();
        m_newData.MetaData = metaData;
        
        // Set Category to Housing
        // Set label to Housing
        m_buildingModel.levels = [];
        m_buildingModel.cystsAmount = 3;
    }

    public WorkshopRecipeBuilder AddRecipe(WorkshopRecipeBuilder recipeBuilder)
    {
        metaData.Builders.Add(recipeBuilder);
        return recipeBuilder;
    }

    public void AddRecipe(WorkshopRecipeModel recipe)
    {
        metaData.Recipes.Add(recipe);
    }
}
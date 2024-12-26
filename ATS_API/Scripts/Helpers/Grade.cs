
using System;
using System.Collections.Generic;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

public enum Grade
{
    Unknown = -1,
    None,
    Zero,
    One,
    Two,
    Three,
}

public static class GradeExtensions
{
    private static readonly Dictionary<Grade, RecipeGradeModel> NameToGrade = new()
    {
        { Grade.Zero, null },
        { Grade.One, null },
        { Grade.Two, null },
        { Grade.Three, null },
    };
    
    public static RecipeGradeModel ToModel(this Grade grade)
    {
        if (!NameToGrade.TryGetValue(grade, out var goodModel))
        {
            APILogger.LogWarning($"Cannot find name of Eremite type of Grade from: " + grade + "\n" + Environment.StackTrace);
            grade = Grade.Zero;
        }

        if (goodModel == null)
        {
            string modelName = GradeToInternalName[grade];
            foreach (RecipeModel building in SO.Settings.recipes)
            {
                if (building.grade.name == modelName)
                {
                    NameToGrade[grade] = building.grade;
                    return building.grade;
                }
            }

            APILogger.LogError($"Cannot find RecipeGradeModel for: " + grade);
            return null;
        }
            
            
        return goodModel;
    }

    internal static readonly Dictionary<Grade, string> GradeToInternalName = new()
    {
        { Grade.Zero, "Grade0" },
        { Grade.One, "Grade1" },
        { Grade.Two, "Grade2" },
        { Grade.Three, "Grade3" },
    };
}
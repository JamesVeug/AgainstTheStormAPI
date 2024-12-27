using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Controller.Generator;
using Eremite.Services;
using Eremite.View.Cameras;
using Eremite.View.Utils;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ATS_API.Biomes;

[HarmonyPatch]
public static partial class BiomeManager
{
    [HarmonyPatch(typeof(PostProcessesAnimator), nameof(PostProcessesAnimator.SetUp))]
    [HarmonyPrefix]
    private static bool PostProcessesAnimator_SetUp(PostProcessesAnimator __instance)
    {
        APILogger.LogDebug("PostProcessesAnimator_SetUp: " + __instance.gameObject.FullName());
        
        BiomeTypes biomeTypes = Serviceable.StateService.Conditions.biomeName.ToBiomeTypes();
        if (!NewBiomeLookup.TryGetValue(biomeTypes, out NewBiome newBiome))
        {
            // APILogger.LogError($"{Serviceable.StateService.Conditions.biomeName} is not a custom biome with type: {biomeTypes} with custom biomes: {NewBiomeLookup.Count}");
            return true;
        }
        
        ChangeRaindrops(newBiome, __instance.gameObject);
        return true;
    }

    private static void ChangeRaindrops(NewBiome newBiome, GameObject fogAnimator)
    {
        if(newBiome.rainPrefab == null)
        {
            return;
        }
        
        ParticleSystem rainDrops = fogAnimator.FindChild<ParticleSystem>("Rain");
        if(rainDrops == null)
        {
            APILogger.LogError("Rain particles not found!");
        }
        else
        {
            GameObject rain = GameObject.Instantiate(newBiome.rainPrefab, rainDrops.transform.parent);
            rain.transform.localPosition = rainDrops.transform.localPosition;
            rain.transform.localRotation = rainDrops.transform.localRotation;
            rain.transform.localScale = rainDrops.transform.localScale;
            rain.SetActive(true);
            rain.name = rainDrops.gameObject.name;
            if (!rain.TryGetComponent(out ScreenParticleScaler _))
            {
                ScreenParticleScaler scaler = rain.AddComponent<ScreenParticleScaler>();
                scaler.Reset(); // Assigns particleSystem to the particle field
            }
            GameObject.Destroy(rainDrops.gameObject);
            APILogger.LogDebug("Raindrops changed!");
        }
        
        // Change Storm/Rain RainDrop
        GameObject storm = fogAnimator.FindChild("Storm");
        if(storm == null)
        {
            APILogger.LogError("Raindrops storm not found!");
        }
        else
        {
            if (storm.TryGetComponent(out ParticleSystem particleSystem))
            {
                GameObject.Destroy(particleSystem);
            }
            
            ParticleSystem stormRainDrop = storm.FindChild<ParticleSystem>("RainDrop");
            if(stormRainDrop == null)
            {
                APILogger.LogError("Storm/RainDrop storm not found!");
            }
            else
            {
                GameObject rain = GameObject.Instantiate(newBiome.rainPrefab, stormRainDrop.transform.parent);
                rain.transform.localPosition = stormRainDrop.transform.localPosition;
                rain.transform.localRotation = stormRainDrop.transform.localRotation;
                rain.transform.localScale = stormRainDrop.transform.localScale;
                rain.SetActive(true);
                rain.name = stormRainDrop.gameObject.name;
                GameObject.Destroy(stormRainDrop.gameObject);
                APILogger.LogDebug("Storm/RainDrop storm changed!");
            }
            
            ParticleSystem stormRainDrop2 = storm.FindChild<ParticleSystem>("RainDrop2");
            if(stormRainDrop2 == null)
            {
                APILogger.LogError("Storm/RainDrop2 storm not found!");
            }
            else
            {
                GameObject rain = GameObject.Instantiate(newBiome.rainPrefab, stormRainDrop2.transform.parent);
                rain.transform.localPosition = stormRainDrop2.transform.localPosition;
                rain.transform.localRotation = stormRainDrop2.transform.localRotation;
                rain.transform.localScale = stormRainDrop2.transform.localScale;
                rain.SetActive(true);
                rain.name = stormRainDrop2.gameObject.name;
                GameObject.Destroy(stormRainDrop2.gameObject);
                APILogger.LogDebug("Storm/RainDrop2 storm changed!");
            }
        }

        // Log the path of all childrens
        // foreach (GameObject gameObject in SceneManager.GetActiveScene().GetRootGameObjects())
        // {
        //     ParticleSystem[] children = gameObject.GetComponentsInChildren<ParticleSystem>(true);
        //     foreach (ParticleSystem child in children)
        //     {
        //         Logger.LogDebug("Child: " + child.FullName());
        //     }
        // }
    }
}
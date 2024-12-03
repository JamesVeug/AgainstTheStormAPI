using ATS_API.Helpers;
using Eremite;
using Eremite.View.Cameras;
using Eremite.View.Utils;
using HarmonyLib;
using UnityEngine;

namespace ATS_API.Biomes;

public static partial class BiomeManager
{
    // [HarmonyPatch(typeof(PostProcessesAnimator), nameof(PostProcessesAnimator.Start))]
    // [HarmonyPostfix]
    // private static void PostProcessesAnimator_Setup_Postfix(PostProcessesAnimator __instance)
    // {
    //     Plugin.Log.LogInfo("PostProcessesAnimator_Setup_Postfix");
    //
    //     BiomeTypes biomeTypes = GameMB.Biome.name.ToBiomeTypes();
    //     if (!NewBiomeLookup.TryGetValue(biomeTypes, out NewBiome newBiome))
    //     {
    //         return;
    //     }
    //
    //     // Apply FX overrides
    //     Plugin.Log.LogInfo($"Setting up post processes for {newBiome.biomeModel.name}");
    //     if (newBiome.stormFX.RaindropMaterial != null)
    //     {
    //         ParticleSystemRenderer rainTexture = __instance.FindChild<ParticleSystemRenderer>("Rain/RainDrop");
    //         ChangeTexture(rainTexture, newBiome.stormFX.Raindrop1Texture);
    //         
    //         ParticleSystemRenderer stormTexture = __instance.FindChild<ParticleSystemRenderer>("Storm");
    //         ChangeTexture(stormTexture, newBiome.stormFX.Raindrop1Texture, true);
    //         
    //         ParticleSystemRenderer stormRaindropTexture = __instance.FindChild<ParticleSystemRenderer>("Storm/RainDrop");
    //         ChangeTexture(stormRaindropTexture, newBiome.stormFX.Raindrop1Texture);
    //     }
    //     
    //     if (newBiome.stormFX.Raindrop2Texture != null)
    //     {
    //         ParticleSystemRenderer rainTexture = __instance.FindChild<ParticleSystemRenderer>("Rain/RainDrop2");
    //         ChangeTexture(rainTexture, newBiome.stormFX.Raindrop2Texture);
    //         
    //         
    //         ParticleSystemRenderer stormTexture = __instance.FindChild<ParticleSystemRenderer>("Storm/RainDrop2");
    //         ChangeTexture(stormTexture, newBiome.stormFX.Raindrop2Texture);
    //     }
    // }
    //
    // [HarmonyPatch(typeof(ScreenParticleScaler), nameof(ScreenParticleScaler.Start))]
    // [HarmonyPrefix]
    // private static bool ScreenParticleScalerStop(ScreenParticleScaler __instance)
    // {
    //     __instance.enabled = false;
    //     return false;
    // }
    //
    // private static void ChangeTexture(ParticleSystemRenderer particleSystemRenderer, Texture2D texture, bool useMainTex=false)
    // {
    //     if (particleSystemRenderer == null) 
    //         return;
    //
    //     // Change size of particles to 1,1,1
    //     ParticleSystem.MainModule mainModule = particleSystemRenderer.GetComponent<ParticleSystem>().main;
    //     mainModule.startSizeX = 0.25f;
    //     mainModule.startSizeY = 0.25f;
    //     mainModule.startSizeZ = 0.25f;
    //     mainModule.startSize = 0.25f;
    //     
    //     ParticleSystem.SizeOverLifetimeModule module = particleSystemRenderer.GetComponent<ParticleSystem>().sizeOverLifetime;
    //     module.separateAxes = false;
    //     module.size = new ParticleSystem.MinMaxCurve(1, AnimationCurve.Linear(0, 1, 1, 1));
    //
    //
    //     Material material1 = particleSystemRenderer.material;
    //     
    //     Texture2D texture2D = (Texture2D)(useMainTex ? material1.mainTexture : material1.GetTexture("_BaseMap"));
    //     if (texture2D != texture)
    //     {
    //         Material material = new Material(particleSystemRenderer.material);
    //         if (useMainTex)
    //         {
    //             Plugin.Log.LogInfo($"Setting main texture for {particleSystemRenderer.name}");
    //             material.SetTexture("_MainTex", texture);
    //         }
    //         else
    //         {
    //             material.SetTexture("_BaseMap", texture);
    //             material.SetTexture("_EmissionMap", texture);
    //         }
    //         particleSystemRenderer.material = material;
    //     }
    // }
}
using ATS_API;
using ATS_API.Helpers;
using Eremite.MapObjects;
using Eremite.View.Utils;
using UnityEngine;

public partial class NaturalResourcePrefabBuilder
{
    public NaturalResourcePrefabBuilder CreateNewPrefab(AssetBundle bundle, string prefabName)
    {
        if (!AssetBundleHelper.TryGet(bundle, prefabName, out GameObject prefabRef))
        {
            APILogger.LogError($"Failed to load prefab {prefabName} from asset bundle {bundle.name}");
            return this;
        }
        
        

        GameObject prefab = GameObject.Instantiate(prefabRef, Plugin.PrefabContainer);
        prefab.name = m_guid + "_" + m_name;
        
        // Prefab -> Container -> ToRotate -> Elements -> Deco -> Bush (1)
        // Prefab -> Container -> ToRotate -> Elements -> Deco -> Bush (2)
        // Prefab -> Container -> ToRotate -> Elements -> Deco -> Bush (3)
        // Prefab -> Container -> ToRotate -> Elements -> Deco -> Bush (4)
        // Prefab -> Container -> ToRotate -> Elements -> Deco -> SmallTree (1)
        // Prefab -> Container -> ToRotate -> AnimationsHooks -> AnimationHook (1)
        // Prefab -> Container -> ToRotate -> AnimationsHooks -> AnimationHook (2)
        // Prefab -> Container -> ToRotate -> Model -> CursedTree_Tilted
        // Prefab -> UI

        // Create scripts
        foreach (MeshRenderer child in prefab.GetComponentsInChildren<MeshRenderer>(true))
        {
            MeshShadowController component = child.gameObject.GetOrAdd<MeshShadowController>();
            component.render = child;
            component.disableAll = false;
        }
        
        NaturalResource naturalResource = prefab.GetOrAdd<NaturalResource>();
        NaturalResourceView view = prefab.GetOrAdd<NaturalResourceView>();
        Animator animator = prefab.GetOrAdd<Animator>();
        
        GameObject deco = prefab.transform.FindChildRecursive("Deco").gameObject;
        foreach (MeshShadowController child in deco.GetComponentsInChildren<MeshShadowController>())
        {
            child.disableAll = true;
        }
        
        GameObject animationHooks = prefab.transform.FindChildRecursive("AnimationsHooks").gameObject;
        VillagersPositioner villagersPositioner = animationHooks.GetOrAdd<VillagersPositioner>();
        villagersPositioner.hooks = new AnimationHook[animationHooks.transform.childCount];
        for (int i = 0; i < animationHooks.transform.childCount; i++)
        {
            Transform child = animationHooks.transform.GetChild(i);
            AnimationHook hook = child.gameObject.GetOrAdd<AnimationHook>();
            hook.type = AnimHookType.Gathering;
            villagersPositioner.hooks[i] = hook;
        }

        // Initialize scripts
        naturalResource.view = view;
        naturalResource.villagersPositioner = villagersPositioner;
        naturalResource.depletionAnimLength = 3;
        
        view.toRotate = prefab.transform.FindChildRecursive("ToRotate");
        view.uiParent = prefab.transform.FindChildRecursive("UI");
        view.animator = animator;
        view.elements = view.toRotate.FindChildRecursive("Elements").gameObject;
        view.meshRenderers = prefab.GetComponentsInChildren<MeshShadowController>(true);
        view.randomRotation = true;
        view.minScale = 0.9f;
        view.maxScale = 1.2f;
        view.minXPos = -0.1f;
        view.maxXPos = 0.1f;
        view.minZPos = -0.1f;
        view.maxZPos = 0.1f;
        view.dustPrefab = null; // TODO: Sync
        view.dustLocalScale = new Vector3(1.25f, 0.8f, 1.25f);
        view.dustPosition = new Vector3(0.95f, 0f, 0f);
        view.dustDelay = 1f;
        
        
        m_customPrefab = naturalResource;
        return this;
    }

    private void SyncCustomPrefab()
    {
        // Sync view.DustPrefab with template NaturalResource (Or add replacement???)
        // Sync animator with template NaturalResource

        Animator component = m_customPrefab.GetComponent<Animator>();
        if (component.runtimeAnimatorController == null)
        {
            NaturalResource naturalResource = NaturalResourcePrefabs.Bay_Tree_1.ToNaturalResource();
            component.runtimeAnimatorController = naturalResource.SafeGetComponent<Animator>().runtimeAnimatorController;
        }
        
        NaturalResourceView view = m_customPrefab.SafeGetComponent<NaturalResourceView>();
        if (view.dustPrefab == null)
        {
            NaturalResource naturalResource = NaturalResourcePrefabs.Bay_Tree_1.ToNaturalResource();
            view.dustPrefab = naturalResource.SafeGetComponent<NaturalResourceView>().dustPrefab;
        }
    }
}
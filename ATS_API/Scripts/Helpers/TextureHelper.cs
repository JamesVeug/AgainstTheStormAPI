using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace ATS_API.Helpers;

/// <summary>
/// This class contains a number of helper methods for managing textures.
/// </summary>
[HarmonyPatch]
public static class TextureHelper
{
    /// <summary>
    /// Thie is used to indicate what type of sprite you wish to create so that the appropriate size and pivot point can be determined.
    /// </summary>
    public enum SpriteType
    {
        /// <summary>
        /// An icon for a cornerstone/perk/effect
        /// </summary>
        EffectIcon = 0,
        TraderIconLarge = 1,
        TraderIconSmall = 2,
        BuildingIcon = 3,
        BuildingDefaultModelDisplayIcon = 4,
    }

    private static Vector2 DEFAULT_PIVOT = new(0.5f, 0.5f);

    private static readonly Dictionary<Sprite, Sprite> emissionMap = new();

    private static readonly Dictionary<SpriteType, Rect> SPRITE_RECTS = new()
    {
        { SpriteType.EffectIcon, new Rect(0.0f, 0.0f, 128.0f, 128.0f) },
        { SpriteType.TraderIconLarge, new Rect(0.0f, 0.0f, 256.0f, 256.0f) },
        { SpriteType.TraderIconSmall, new Rect(0.0f, 0.0f, 63.0f, 63.0f) },
        { SpriteType.BuildingIcon, new Rect(0.0f, 0.0f, 128.0f, 128.0f) },
        { SpriteType.BuildingDefaultModelDisplayIcon, new Rect(0.0f, 0.0f, 512.0f, 512.0f) },
    };

    private static readonly Dictionary<SpriteType, Vector2> SPRITE_PIVOTS = new()
    {
        { SpriteType.EffectIcon, DEFAULT_PIVOT },
        { SpriteType.TraderIconLarge, DEFAULT_PIVOT },
        { SpriteType.TraderIconSmall, DEFAULT_PIVOT },
        { SpriteType.BuildingIcon, DEFAULT_PIVOT },
        { SpriteType.BuildingDefaultModelDisplayIcon, DEFAULT_PIVOT },
    };
    
    public static Texture2D GetWhiteTexture(SpriteType spriteType)
    {
        SPRITE_RECTS.TryGetValue(spriteType, out Rect rect);
        Texture2D texture = new((int)rect.width, (int)rect.height, TextureFormat.RGBA32, false);
        Color[] pixels = new Color[texture.width * texture.height];
        for (int i = 0; i < pixels.Length; i++)
        {
            pixels[i] = Color.white;
        }

        texture.SetPixels(pixels);
        texture.Apply();
        return texture;
    }

    /// <summary>
    /// Reads the contents of an image file on disk and returns it as a byte array.
    /// </summary>
    /// <param name="pathCardArt">The path to the card on disk. This can be relative to the BepInEx plugin path, or can be an absolute (rooted) path.</param>
    /// <returns>The contents of the file in pathCardArt as a byte array.</returns>
    public static byte[] ReadArtworkFileAsBytes(string pathCardArt)
    {
        if (!Path.IsPathRooted(pathCardArt))
        {
            var files = Directory.GetFiles(Paths.PluginPath, pathCardArt, SearchOption.AllDirectories);
            if (files.Length < 1)
                throw new FileNotFoundException($"Could not find relative artwork file!\nFile name: {pathCardArt}", pathCardArt);

            pathCardArt = files[0];
        }

        if (!File.Exists(pathCardArt))
            throw new FileNotFoundException($"Absolute path to artwork file does not exist!\nFile name: {pathCardArt}", pathCardArt);

        return File.ReadAllBytes(pathCardArt);
    }

    /// <summary>
    /// Converts an artwork file on disk to a Unity Texture2D object.
    /// </summary>
    /// <param name="pathCardArt">The path to the card on disk. This can be relative to the BepInEx plugin path, or can be an absolute (rooted) path.</param>
    /// <param name="filterMode">Sets the filter mode of the art. Leave this alone unless you know why you're changing it.</param>
    /// <returns>The image file on disk as a Texture2D object.</returns>
    public static Texture2D GetImageAsTexture(string pathCardArt, FilterMode filterMode = FilterMode.Point)
    {
        Texture2D texture = new(2, 2, TextureFormat.RGBA32, false);
        byte[] imgBytes = ReadArtworkFileAsBytes(pathCardArt);
        bool isLoaded = texture.LoadImage(imgBytes);

        texture.filterMode = filterMode;
        texture.name = Path.GetFileNameWithoutExtension(pathCardArt);

        return texture;
    }

    /// <summary>
    /// Converts an artwork file stored as a resource in an assembly file to a Unity Texture2D object.
    /// </summary>
    /// <param name="pathCardArt">The name of the artwork file in the assembly.</param>
    /// <param name="target">The assembly to pull the artwork file from.</param>
    /// <param name="filterMode">Sets the filter mode of the art. Leave this alone unless you know why you're changing it.</param>
    /// <returns>The image file from the assembly as a Texture2D object.</returns>
    public static Texture2D GetImageAsTexture(string pathCardArt, Assembly target, FilterMode filterMode = FilterMode.Point)
    {
        Texture2D texture = new(2, 2, TextureFormat.RGBA32, false);
        byte[] imgBytes = GetResourceBytes(pathCardArt, target);
        texture.LoadImage(imgBytes);
        texture.filterMode = filterMode;
        texture.name = Path.GetFileNameWithoutExtension(pathCardArt);

        return texture;
    }

    /// <summary>
    /// Converts a Unity Texture2D object to a Sprite that conforms to the expectations for the given sprite type.
    /// </summary>
    /// <param name="texture">The Texture2D object to convert.</param>
    /// <param name="spriteType">The type of sprite to create.</param>
    /// <param name="filterMode">Sets the filter mode of the art. Leave this alone unless you know why you're changing it.</param>
    /// <returns>A sprite containing the given texture.</returns>
    public static Sprite ConvertTexture(this Texture2D texture, SpriteType spriteType, FilterMode filterMode = FilterMode.Point)
    {
        texture.filterMode = filterMode;
        Sprite retval = Sprite.Create(texture, SPRITE_RECTS[spriteType], SPRITE_PIVOTS[spriteType]);
        retval.name = texture.name;
        return retval;
    }

    /// <summary>
    /// Converts a Unity Texture2D object to a Sprite with the same dimensions as the texture.
    /// </summary>
    /// <param name="texture">The Texture2D object to convert.</param>
    /// <param name="pivot">The pivot of the sprite. If null/default, the pivot will be the middle of the texture.</param>
    /// <returns>A sprite containing the given texture.</returns>
    public static Sprite ConvertTexture(this Texture2D texture, Vector2? pivot = null)
    {
        pivot ??= new Vector2(0.5f, 0.5f);
        Sprite retval = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), pivot.Value);
        retval.name = texture.name;
        return retval;
    }

    /// <summary>
    /// Converts an image on disk to a Sprite that conforms to the expectations for the given sprite type.
    /// </summary>
    /// <param name="pathCardArt">The path to the card on disk. This can be relative to the BepInEx plugin path, or can be an absolute (rooted) path.</param>
    /// <param name="spriteType">The type of sprite to create.</param>
    /// <param name="filterMode">Sets the filter mode of the art. Leave this alone unless you know why you're changing it.</param>
    /// <returns>A sprite containing the image file on disk.</returns>
    public static Sprite GetImageAsSprite(string pathCardArt, SpriteType spriteType, FilterMode filterMode = FilterMode.Point)
    {
        return GetImageAsTexture(pathCardArt).ConvertTexture(spriteType, filterMode);
    }
    /// <summary>
    /// Converts an artwork file stored as a resource in an assembly file to a Sprite that conforms to the expectations for the given sprite type.
    /// </summary>
    /// <param name="pathCardArt">The path to the card on disk. This can be relative to the BepInEx plugin path, or can be an absolute (rooted) path.</param>
    /// <param name="target">The assembly to pull the artwork file from.</param>
    /// <param name="spriteType">The type of sprite to create.</param>
    /// <param name="filterMode">Sets the filter mode of the art. Leave this alone unless you know why you're changing it.</param>
    /// <returns>A sprite containing the image file from the assembly.</returns>
    public static Sprite GetImageAsSprite(string pathCardArt, Assembly target, SpriteType spriteType, FilterMode filterMode = FilterMode.Point)
    {
        return GetImageAsTexture(pathCardArt, target).ConvertTexture(spriteType, filterMode);
    }

    /// <summary>
    /// Reads the contents of an image file in an assembly and returns it as a byte array.
    /// </summary>
    /// <param name="pathCardArt">The name of the art file stored as a resource in the assembly.</param>
    /// <param name="target">The assembly to pull the art from.</param>
    /// <returns>The contents of the file in pathCardArt as a byte array.</returns>
    public static byte[] GetResourceBytes(string filename, Assembly target)
    {
        string lowerKey = $".{filename.ToLowerInvariant()}";
        string resourceName = target.GetManifestResourceNames().FirstOrDefault(r => r.ToLowerInvariant().EndsWith(lowerKey));

        if (string.IsNullOrEmpty(resourceName))
            throw new KeyNotFoundException($"Could not find resource matching {filename} in assembly {target}.");

        using (Stream resourceStream = target.GetManifestResourceStream(resourceName))
        {
            using (MemoryStream memStream = new())
            {
                resourceStream.CopyTo(memStream);
                return memStream.ToArray();
            }
        }
    }

    /// <summary>
    /// Combines multiple textures into one, using a tiled approach.
    /// </summary>
    /// <remarks>
    /// This helper has a very specific purpose. The pixels in <paramref>baseTexture</paramref> will be iteratively replaced with the pixels
    /// in the <paramref>pieces</paramref> array. The X position for the i-th texture will be 
    /// <paramref>xOffset</paramref> + <paramref>xStep</paramref> * i. The Y position for the i-th texture will be
    /// <paramref>yOffset</paramref> + <paramref>yStep</paramref> * (<paramref>pieces</paramref>.Count - i - 1).
    /// 
    /// **Note**: <paramref>baseTexture</paramref> will be modified in-place!
    /// </remarks>
    /// <param name="pieces">The individual textures to combine into the base texture.</param>
    /// <param name="baseTexture">The background texture for the combined texture.</param>
    /// <param name="xStep">Used to set the position for individual textures.</param>
    /// <param name="yStep">Used to set the position for individual textures.</param>
    /// <param name="xOffset">Used to set the position for individual textures.</param>
    /// <param name="yOffset">Used to set the position for individual textures.</param>
    /// <returns>The modified texture (the same Texture references as <paramref>baseTexture</paramref>).</returns>
    public static Texture2D CombineTextures(List<Texture2D> pieces, Texture2D baseTexture, int xStep = 0, int yStep = 0, int xOffset = 0, int yOffset = 0)
    {
        if (pieces != null)
        {
            for (int j = 0; j < pieces.Count; j++)
                if (pieces[j] != null)
                    baseTexture.SetPixels(xOffset + xStep * j, yOffset + yStep * (pieces.Count - j - 1), pieces[j].width, pieces[j].height, pieces[j].GetPixels(), 0);

            baseTexture.Apply();
        }

        return baseTexture;
    }

    /// <summary>
    /// Creates an identical copy of a given texture
    /// </summary>
    /// <param name="texture">The texture to copy.</param>
    public static Texture2D DuplicateTexture(Texture2D texture)
    {
        // https://support.unity.com/hc/en-us/articles/206486626-How-can-I-get-pixels-from-unreadable-textures-
        // Create a temporary RenderTexture of the same size as the texture

        RenderTexture tmp = RenderTexture.GetTemporary(
                            texture.width,
                            texture.height,
                            0,
                            RenderTextureFormat.Default,
                            RenderTextureReadWrite.Linear);


        // Blit the pixels on texture to the RenderTexture
        Graphics.Blit(texture, tmp);

        // Backup the currently set RenderTexture
        RenderTexture previous = RenderTexture.active;

        // Set the current RenderTexture to the temporary one we created
        RenderTexture.active = tmp;

        // Create a new readable Texture2D to copy the pixels to it

        Texture2D myTexture2D = new(texture.width, texture.height);

        // Copy the pixels from the RenderTexture to the new Texture
        myTexture2D.ReadPixels(new Rect(0, 0, tmp.width, tmp.height), 0, 0);
        myTexture2D.Apply();

        // Reset the active RenderTexture
        RenderTexture.active = previous;

        // Release the temporary RenderTexture
        RenderTexture.ReleaseTemporary(tmp);

        return myTexture2D;
    }

    public static Texture2D GetReadableTexture(Texture2D texture)
    {
        var readableTexture = texture;
        if (!texture.isReadable)
        {
            RenderTexture renderTex = RenderTexture.GetTemporary(
                texture.width,
                texture.height,
                0,
                RenderTextureFormat.Default,
                RenderTextureReadWrite.Linear);

            Graphics.Blit(texture, renderTex);
            RenderTexture previous = RenderTexture.active;
            Texture2D readableText = new Texture2D(texture.width, texture.height, TextureFormat.RGBA32, false, true);
            RenderTexture.active = renderTex;
            readableText.ReadPixels(new Rect(0, 0, renderTex.width, renderTex.height), 0, 0);
            readableText.Apply();
            RenderTexture.active = previous;
            RenderTexture.ReleaseTemporary(renderTex);
            readableTexture = readableText;
        }

        return readableTexture;
    }
    
    public static Texture2D ResizeTexture(Texture2D sourceTexture, int width, int height)
    {
        RenderTexture previous = RenderTexture.active;
        RenderTexture rt = RenderTexture.GetTemporary(
            width,
            height,
            0,
            RenderTextureFormat.Default,
            RenderTextureReadWrite.Linear);
        
        RenderTexture.active = rt;
        Graphics.Blit(sourceTexture,rt);
        var sourceTextureResized = new Texture2D(width,height);
        sourceTextureResized.ReadPixels(new Rect(0,0,width,height),0,0);
        sourceTextureResized.Apply();
        
        RenderTexture.active = previous;
        RenderTexture.ReleaseTemporary(rt);
        return sourceTextureResized;
    }
    
    public static void ExportTextureToAssets(Texture2D texture, string fullPath)
    {
        byte[] bytes = texture.EncodeToPNG();
        string directory = Path.GetDirectoryName(fullPath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
                
        Plugin.Log.LogInfo($"Writing {fullPath}");
        File.WriteAllBytes(fullPath, bytes);
    }
}

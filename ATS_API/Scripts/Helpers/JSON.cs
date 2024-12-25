using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Eremite;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using UnityEngine;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;

namespace ATS_API.Helpers;

public static class JSONSerializer
{
    public class Result
    {
        public string JSON;
        public List<UnityObjectConverter.SubObjects> SubObjects;
    }
    private static readonly UnityObjectConverter converter = new UnityObjectConverter();
    private static readonly JsonSerializerSettings jsonSettings = new JsonSerializerSettings
    {
        TypeNameHandling = TypeNameHandling.Objects,
        PreserveReferencesHandling = PreserveReferencesHandling.All,
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        Formatting = Formatting.Indented,
        NullValueHandling = NullValueHandling.Ignore,
        Error = Error,
        Converters = new List<JsonConverter>(){new StringEnumConverter(), converter},
        ContractResolver = new IgnorePropertiesResolver()
    };
    
    public static Result ToJson(object obj)
    {
        converter.SubObjectsList.Clear();
        string json = JsonConvert.SerializeObject(obj, jsonSettings);
        return new Result()
        {
            JSON = json,
            SubObjects = converter.SubObjectsList
        };
    }

    private class IgnorePropertiesResolver : DefaultContractResolver
    {
        public IgnorePropertiesResolver()
        {
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            if (member is PropertyInfo)
            {
                property.ShouldSerialize = instance =>
                {
                    return false; 
                };
            }
            else
            {
                var originalValueProvider = property.ValueProvider;
                property.ValueProvider = new SafeValueProvider(originalValueProvider);
            }
            return property;
        }

        class SafeValueProvider : IValueProvider
        {
            IValueProvider OriginalValueProvider;

            public SafeValueProvider(IValueProvider originalValueProvider)
            {
                OriginalValueProvider = originalValueProvider;
            }

            public object GetValue(object target)
            {
                try
                {
                    return OriginalValueProvider.GetValue(target);
                }
                catch(Exception ex)
                {
                    return null;
                }
            }

            public void SetValue(object target, object value)
            {
                OriginalValueProvider.SetValue(target, value);
            }
        }
    }

    public class UnityObjectConverter : JsonConverter
    {
        public class SubObjects
        {
            public string Path;
            public byte[] Bytes;
        }
        
        public List<SubObjects> SubObjectsList = new List<SubObjects>();

        public override bool CanConvert(Type objectType)
        {
            return typeof(UnityEngine.Object).IsAssignableFrom(objectType) && !objectType.IsSubclassOf(typeof(ScriptableObject));
        }
        
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var unityObject = value as UnityEngine.Object;
            string writerPath = writer.Path.Replace(".", "_");
            // if (unityObject is Sprite sprite)
            // {
            //     string path = writerPath + ".png";
            //     Texture2D croppedTexture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height);
            //     Color[] pixels = TextureHelper.GetReadableTexture(sprite.texture).GetPixels((int)sprite.textureRect.x, 
            //         (int)sprite.textureRect.y, 
            //         (int)sprite.rect.width, 
            //         (int)sprite.rect.height);
            //     croppedTexture.SetPixels(pixels);
            //     croppedTexture.Apply();
            //
            //     SubObjectsList.Add(new SubObjects()
            //     {
            //         Path = path,
            //         Bytes = croppedTexture.EncodeToPNG()
            //     });
            //
            //     writer.WriteValue(path + " " + unityObject.GetType().FullName);
            // }
            /* else */if (unityObject is Texture2D texture)
            {
                string path = writerPath + ".png";
                SubObjectsList.Add(new SubObjects()
                {
                    Path = path,
                    Bytes = TextureHelper.GetReadableTexture(texture).EncodeToPNG()
                });
                
                writer.WriteValue(path + " " + unityObject.GetType().FullName);
            }
            else
            {
                writer.WriteValue(unityObject.name + " " + unityObject.GetType().FullName);
            }
        }
        
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new JsonSerializationException("Cannot read UnityEngine.Object");
        }
    }
    
    private static void Error(object sender, ErrorEventArgs e)
    {
        APILogger.LogError(e.ErrorContext.Error.Message);
    }
        
    public static void DumpPerksToJSON<T>(T[] effectModels, string key) where T : SO
    {
        APILogger.LogInfo($"Exporting {effectModels.Length} to JSON.");
        foreach (var model in effectModels)
        {
            try
            {
                JSONSerializer.Result json = JSONSerializer.ToJson(model);
                string path = Path.Combine(Plugin.PluginDirectory, "Exports", key, model.Name) + ".json";

                // Create directory if it doesn't exist
                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Write to file
                File.WriteAllText(path, json.JSON);
                    
                APILogger.LogInfo($"Exported {model.Name}'s SubObjects {json.SubObjects.Count} to JSON.");
                foreach (JSONSerializer.UnityObjectConverter.SubObjects subObject in json.SubObjects)
                {
                    string subPath = Path.Combine(Plugin.PluginDirectory, "Exports", "Assets", model.name + "_" + subObject.Path);
                    APILogger.LogInfo($"- {subPath}");
                        
                    // Create directory if it doesn't exist
                    string subDirectory = Path.GetDirectoryName(subPath);
                    if (!Directory.Exists(subDirectory))
                    {
                        Directory.CreateDirectory(subDirectory);
                    }
                        
                    if (!File.Exists(subPath))
                    {
                        File.WriteAllBytes(subPath, subObject.Bytes);
                    }
                }
            }
            catch (Exception e)
            {
                APILogger.LogError("Failed to dump good to JSON: " + model.Name);
                APILogger.LogError(e);
            }
        }
    }
}
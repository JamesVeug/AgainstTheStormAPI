using System;
using BepInEx;
using Newtonsoft.Json;

public static class PluginInfoExtensions
{
    public class PluginManifest
    {
        public string name;
        
        [JsonProperty]
        private string version_number;
        
        public string website_url;
        public string description;
        
        [JsonProperty]
        private string[] dependencies;
        
        public Version ManifestVersion()
        {
            Version version = new Version();
            Version.TryParse(version_number, out version);
            return version;
        }
        
        public struct Dependency
        {
            public string Team;
            public string Name;
            public Version Version;
        }
        
        public Dependency[] Dependencies()
        {
            Dependency[] deps = new Dependency[dependencies.Length];
            for (int i = 0; i < dependencies.Length; i++)
            {
                string[] parts = dependencies[i].Split('-');
                Dependency dependency = new Dependency();
                dependency.Team = parts[0];
                dependency.Name = parts[1];
                Version.TryParse(parts[2], out dependency.Version);
                
                deps[i] = dependency;
            }

            return deps;
        }
    }
    
    public static PluginManifest Manifest(this PluginInfo plugin)
    {
        // Find file in the plugins directory
        string directory = System.IO.Path.GetDirectoryName(plugin.Location);
        string[] files = System.IO.Directory.GetFiles(directory, "manifest.json", System.IO.SearchOption.AllDirectories);
        if (files.Length > 0)
        {
            string manifest = System.IO.File.ReadAllText(files[0]);
            return JsonConvert.DeserializeObject<PluginManifest>(manifest);
        }

        return null;
    }
}
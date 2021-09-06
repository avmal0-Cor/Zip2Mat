using Newtonsoft.Json;
using System.IO;

namespace Zip2Mat
{
    public class MainSettings
    {
        public string MatLocation = @"C:\default_folder_CHANGEME_IN_CONFIG_JSON\okay"; // default

        private static MainSettings instance;
        public static MainSettings Instance 
        { 
            get
            {
                if (instance == null)
                    instance = ReadFromJson("config.json");

                return instance;
            }
        }

        public static MainSettings ReadFromJson(string file)
        {
            var mainSettings = JsonConvert.DeserializeObject<MainSettings>(File.ReadAllText(file));
            return mainSettings;
        }
    }
}

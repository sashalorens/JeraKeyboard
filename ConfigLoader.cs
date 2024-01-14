using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JeraKeyboard
{
    public static class ConfigLoader
    {
        private static bool isConfigExists = false;

        public static JObject? LoadConfig()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = "JeraKeyboard.Resources.jeraDefaultConfig.json";
                string jsonString = String.Empty;

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    jsonString = reader.ReadToEnd(); //Make string equal to full file
                }

                var jsonFile = JSONConverter.FromJson(jsonString);

                /* String jsonString = File.ReadAllText("C:\\Users\\utto6\\Desktop\\projects\\c#\\3\\JeraKeyboard\\config.json", Encoding.UTF8);
                var jsonFile = JSONConverter.FromJson(jsonString); */
                isConfigExists = true;
                return jsonFile;
            }
            catch (Exception)
            {
                isConfigExists = false;
                return null;
            }
        }

        public static bool IsConfigExists() => isConfigExists;
    }
}

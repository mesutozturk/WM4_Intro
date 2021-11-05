using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace KisiEnvanter
{
    public static class KisiContext
    {
        private static string _path =
            //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/KisiEnvanteri/db.json";
            "C:/KisiEnvanteri/db.json";
        public static List<Kisi> Kisiler { get; set; } = new List<Kisi>();

        public static void Load()
        {
            if (File.Exists(_path))
            {
                try
                {
                    FileStream fileStream = new FileStream(_path, FileMode.Open);
                    StreamReader reader = new StreamReader(fileStream);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();
                    Kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Directory.CreateDirectory("C:/KisiEnvanteri");
            }
        }
        public static void Save()
        {
            try
            {
                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(Kisiler, Formatting.Indented));
                writer.Close();
                writer.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}

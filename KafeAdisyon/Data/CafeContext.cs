using System;
using KafeAdisyon.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace KafeAdisyon.Data
{
    public class CafeContext
    {
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/kafe.json";

        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public List<Kategori> Kategoriler { get; set; } = new List<Kategori>();
        public KafeBilgi KafeBilgi { get; set; }
        public List<Kat> Katlar { get; set; } = new List<Kat>();
        public List<Masa> Masalar { get; set; } = new List<Masa>();
        public List<Siparis> Siparisler { get; set; } = new List<Siparis>();

        public void Load()
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
                    var context = JsonConvert.DeserializeObject<CafeContext>(dosyaIcerigi);
                    this.KafeBilgi = context.KafeBilgi;
                    this.Kategoriler = context.Kategoriler;
                    this.Katlar = context.Katlar;
                    this.Masalar = context.Masalar;
                    this.Urunler = context.Urunler;
                    this.Siparisler = context.Siparisler;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Directory.CreateDirectory(_path);
            }
        }

        public void Save()
        {
            try
            {
                File.Delete(_path);
                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
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

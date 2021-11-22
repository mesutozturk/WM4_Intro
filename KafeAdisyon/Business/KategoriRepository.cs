using KafeAdisyon.Data;
using KafeAdisyon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KafeAdisyon.Business
{
    public class KategoriRepository : IRepository<Kategori>
    {
        public CafeContext Context { get; set; }

        public Kategori Get(Guid id)
        {
            return Context.Kategoriler.FirstOrDefault(x => x.Id == id);
        }

        public List<Kategori> GetAll(Func<Kategori, bool> predicate = null)
        {
            return predicate == null ? Context.Kategoriler : Context.Kategoriler.Where(predicate).ToList();
        }

        public void AddProduct(Kategori kategori, Urun urun)
        {
            Context.Kategoriler.First(x => x.Id == kategori.Id).Urunler.Add(urun);
            Context.Save();
        }
        public void Add(Kategori item)
        {
            Context.Kategoriler.Add(item);
            Context.Save();
        }

        public void Remove(Kategori item)
        {
            Context.Kategoriler.Remove(item);
            Context.Save();
        }

        public void Update()
        {
            Context.Save();
        }
    }
}

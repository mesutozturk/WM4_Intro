using KafeAdisyon.Data;
using KafeAdisyon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KafeAdisyon.Business
{
    public class KategoryRepository : IRepository<Kategori>
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

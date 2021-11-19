using KafeAdisyon.Data;
using KafeAdisyon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KafeAdisyon.Business
{
    public class UrunRepository : IRepository<Urun>
    {
        public CafeContext Context { get; set; }
        public Urun Get(Guid id)
        {
            return Context.Urunler.FirstOrDefault(x => x.Id == id);
        }

        public List<Urun> GetAll(Func<Urun, bool> predicate = null)
        {
            return predicate == null ? Context.Urunler : Context.Urunler.Where(predicate).ToList();
        }

        public void Add(Urun item)
        {
            Context.Urunler.Add(item);
            Context.Save();
        }

        public void Remove(Urun item)
        {
            Context.Urunler.Remove(item);
            Context.Save();
        }

        public void Update()
        {
            Context.Save();
        }
    }
}
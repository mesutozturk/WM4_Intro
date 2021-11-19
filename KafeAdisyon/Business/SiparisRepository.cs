using System;
using System.Collections.Generic;
using System.Linq;
using KafeAdisyon.Data;
using KafeAdisyon.Model;

namespace KafeAdisyon.Business
{
    public class SiparisRepository : IRepository<Siparis>
    {
        public CafeContext Context { get; set; }
        public Siparis Get(Guid id)
        {
            return Context.Siparisler.FirstOrDefault(x => x.Id == id);
        }

        public List<Siparis> GetAll(Func<Siparis, bool> predicate = null)
        {
            return predicate == null ? Context.Siparisler : Context.Siparisler.Where(predicate).ToList();
        }

        public void Add(Siparis item)
        {
            Context.Siparisler.Add(item);
            Context.Save();
        }

        public void Remove(Siparis item)
        {
            Context.Siparisler.Remove(item);
            Context.Save();
        }

        public void Update()
        {
            Context.Save();
        }
    }
}
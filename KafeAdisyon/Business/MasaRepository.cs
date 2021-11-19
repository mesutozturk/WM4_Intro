using System;
using System.Collections.Generic;
using System.Linq;
using KafeAdisyon.Data;
using KafeAdisyon.Model;

namespace KafeAdisyon.Business
{
    public class MasaRepository : IRepository<Masa>
    {
        public CafeContext Context { get; set; }
        public Masa Get(Guid id)
        {
            return Context.Masalar.FirstOrDefault(x => x.Id == id);
        }

        public List<Masa> GetAll(Func<Masa, bool> predicate = null)
        {
            return predicate == null ? Context.Masalar : Context.Masalar.Where(predicate).ToList();
        }

        public void Add(Masa item)
        {
            Context.Masalar.Add(item);
            Context.Save();
        }

        public void Remove(Masa item)
        {
            Context.Masalar.Remove(item);
            Context.Save();
        }

        public void Update()
        {
            Context.Save();
        }
    }
}
using GestioneOrdiniRistorante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions
{
    public class OrdineRepo : GenericRepository<Ordine>
    {
        public MyDBContent DB;

        public OrdineRepo(MyDBContent T) : base(T)
        {
            DB = T;
        }

        public void Add(Ordine T)
        {
            DB.Add(T);
        }

        public void AddAsync(Ordine T)
        {
            DB.AddAsync(T);
        }

        public Ordine FindById(int i)
        {
            var T = DB.Set<Ordine>().Find(i);
            return T;
        }
    }
}

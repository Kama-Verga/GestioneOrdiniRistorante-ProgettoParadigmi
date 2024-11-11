using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneOrdiniRistorante.Models;

namespace GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions
{
    public class ProdottoRepo : GenericRepository<Prodotto>
    {
        public MyDBContent DB;

        public ProdottoRepo(MyDBContent T) : base(T)
        {
            
        }

        public void Add(Prodotto T)
        {
            DB.Add(T);
        }
        
        public Prodotto FindById(int i)
        {
            return DB.Set<Prodotto>().Find(i);
        }

    }
}

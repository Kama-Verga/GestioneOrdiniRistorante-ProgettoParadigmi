using GestioneOrdiniRistorante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions
{
    public class UtenteRepo : GenericRepository<Utente>
    {
        public MyDBContent DB;

        public UtenteRepo(MyDBContent T) : base(T)
        {
            DB = T;
        }

        public void Add(Utente T)
        {
            DB.Add(T);
        }

        public Utente FindById(int i)
        {
            return DB.Set<Utente>().Find(i);
        }

    }
    
}

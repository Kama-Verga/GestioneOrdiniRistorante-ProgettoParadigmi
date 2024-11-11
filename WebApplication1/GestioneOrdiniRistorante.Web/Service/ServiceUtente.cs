using GestioneOrdiniRistorante.Models;
using GestioneOrdiniRistorante.Application.Service.Interface;
using GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions;

namespace GestioneOrdiniRistorante.Service
{
    public class ServiceUtente : ServiceUtenteInt
    {

        private readonly UtenteRepo UtenteDB;
        public ServiceUtente(UtenteRepo UR)
        {
            UtenteDB = UR;
        }
        public Utente CreaUtente(Utente T)
        {
            UtenteDB.Add(T);
            UtenteDB.Save();
            Console.WriteLine(T.Nome);
            return T;
        }



    }
}

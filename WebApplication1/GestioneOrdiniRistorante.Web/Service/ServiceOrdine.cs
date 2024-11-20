using GestioneOrdiniRistorante.Models;
using System.ComponentModel.Design;
using GestioneOrdiniRistorante.Infrastructure;
using GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions;
using GestioneOrdiniRistorante.Application.Service.Interface;
using GestioneOrdiniRistorante.Models.Models.DTO;

namespace GestioneOrdiniRistorante.Service
{
    public class ServiceOrdine : ServiceOrdineInt
    {

        private readonly OrdineRepo OrdineDB;
        int Numero_ordine_corrente = 0;

        public ServiceOrdine(OrdineRepo OR)
        {
            OrdineDB = OR;
        }
        public Ordine CreaOrdine(Ordine T)
        {
            OrdineDB.Add(T);
            OrdineDB.Save();
            return T;
        }

        public List<Ordine> TrovaOrdiniDaUtente(Utente a)
        {
            throw new NotImplementedException();
        }

        public List<Ordine> TrovaOrdini()
        {
            throw new NotImplementedException();
        }
    }
}

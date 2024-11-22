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

        public ServiceOrdine(OrdineRepo OR)
        {
            OrdineDB = OR;
        }
        public async Task<Ordine> CreaOrdine(Ordine ordine)
        {
            OrdineDB.AddAsync(ordine); // Aggiunge l'ordine
            await OrdineDB.SalvaDatiAsync(); // Salva solo una volta al termine
            Console.WriteLine(ordine.MailCreatore);
            return ordine;
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

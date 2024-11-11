using GestioneOrdiniRistorante.Models;
using System.ComponentModel.Design;
using GestioneOrdiniRistorante.Infrastructure;
using GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions;
using GestioneOrdiniRistorante.Application.Service.Interface;

namespace GestioneOrdiniRistorante.Service
{
    public class ServiceOrdine : ServiceOrdineInt
    {
        int Numero_ordine_corrente = 0;

        public ServiceOrdine()
        {
            throw new NotImplementedException();
        }
        public Ordine CreaOrdine()
        {
            throw new NotImplementedException();
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

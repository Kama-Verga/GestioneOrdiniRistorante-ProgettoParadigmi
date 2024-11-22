using GestioneOrdiniRistorante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante.Application.Service.Interface
{
    public interface ServiceOrdineInt
    {
        Task<Ordine> CreaOrdine(Ordine a);

        List<Ordine> TrovaOrdiniDaUtente(Utente a);
        List<Ordine> TrovaOrdini();

    }
}

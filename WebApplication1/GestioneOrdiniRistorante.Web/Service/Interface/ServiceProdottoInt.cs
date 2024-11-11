using GestioneOrdiniRistorante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante.Application.Service.Interface
{
    internal interface ServiceProdottoInt
    {
        Prodotto TrovaProdotto(int Id);
        List<Prodotto> Menu();
    }
}

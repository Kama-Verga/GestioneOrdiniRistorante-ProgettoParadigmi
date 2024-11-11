using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneOrdiniRistorante.Application.Service.Interface;
using GestioneOrdiniRistorante.Models;
using GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions;

namespace GestioneOrdiniRistorante.Application.Service
{
    internal class ServiceProdotto : ServiceProdottoInt
    {
        ProdottoRepo ProdottoDB;
        public ServiceProdotto(ProdottoRepo PR) 
        {
            ProdottoDB = PR;
        }

        public Prodotto TrovaProdotto(int Id)
        {
            return new Prodotto();
        }

        public List<Prodotto> Menu()
        {
            return new List<Prodotto>();
        }


    }
}

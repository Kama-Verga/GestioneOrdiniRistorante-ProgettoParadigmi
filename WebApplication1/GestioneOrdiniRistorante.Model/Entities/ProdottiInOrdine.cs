using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante.Models.Entities
{
    public class ProdottiInOrdine
    {
        public int OrdineId { get; set; }
        public Ordine Ordine { get; set; }

        public int ProdottoId { get; set; }
        public Prodotto Prodotto { get; set; }

        public ProdottiInOrdine() { }
        public ProdottiInOrdine(Ordine T, Prodotto TT ) { 
            Ordine = T;
            Prodotto = TT;
        }
    }
}

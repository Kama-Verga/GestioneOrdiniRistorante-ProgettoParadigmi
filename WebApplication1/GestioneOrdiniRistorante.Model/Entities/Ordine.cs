
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using GestioneOrdiniRistorante.Models.Entities;

namespace GestioneOrdiniRistorante.Models
{
    public class Ordine
    {
        [Key]
        public int Id;
        public String MailCreatore { get; set; }
        public DateTime Data_creazione { get; set; }
        public int Numero_Ordine { get; set; }
        public String Indirizzo_Di_Consegna { get; set; }
        public decimal Prezzo { get; set; }

        // Relazione molti-a-molti con OrdineProdotto
        public ICollection<ProdottiInOrdine> OrdineProdotti { get; set; } = new List<ProdottiInOrdine>();

        public Ordine(String MailCreatore, int Numero_Ordine, String Indirizzo_Di_Consegna)
        {
            this.MailCreatore = MailCreatore;
            this.Data_creazione = DateTime.Now;
            this.Numero_Ordine = Numero_Ordine;
            this.Indirizzo_Di_Consegna = Indirizzo_Di_Consegna;
        }
        public void AggiungiProdotto(Prodotto T)
        {
            ProdottiInOrdine PIT = new ProdottiInOrdine(this, T);

            OrdineProdotti.Add(PIT);
        }


    }
}

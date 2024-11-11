using System.Diagnostics.CodeAnalysis;

namespace GestioneOrdiniRistorante.Models
{
    public class Ordine
    {
        public Utente Creatore { get; set; }
        public DateTime Data_creazione { get; set; }
        public int Numero_Ordine { get; set; }
        public String Indirizzo_Di_Consegna { get; set; }
        public String Contenuto { get; set; }
        public double Prezzo;

        public Ordine(Utente Creatore, DateTime Data_creazione, int Numero_Ordine, String Contenuto, double Prezzo)
        {
            this.Creatore = Creatore;
            this.Data_creazione = Data_creazione;
            this.Numero_Ordine = Numero_Ordine;
            this.Contenuto = Contenuto;
            this.Prezzo = Prezzo; 
        }

        public Ordine(Utente Creatore, DateTime Data_creazione, int Numero_Ordine, String Contenuto, double Prezzo, String Indirizzo_Di_Consegna)
        {
            this.Creatore = Creatore;
            this.Data_creazione = Data_creazione;
            this.Numero_Ordine = Numero_Ordine;
            this.Contenuto = Contenuto;
            this.Prezzo = Prezzo;
            this.Indirizzo_Di_Consegna = Indirizzo_Di_Consegna;
        }



    }
}

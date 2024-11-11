namespace GestioneOrdiniRistorante.Models
{
    public class Prodotto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public Portata Tipo { get; set; }

        public Prodotto()
        {

        }    
    
    }

    public enum Portata
    {
        Primo,
        Secondo,
        Contorno,
        Dolce
    }

}

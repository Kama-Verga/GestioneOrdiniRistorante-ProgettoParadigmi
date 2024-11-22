﻿using System.Data;
using System.Text.Json.Serialization;

namespace GestioneOrdiniRistorante.Models.Models.Request
{
    public class CreaOrdineReq
    {
        public String MailCreatore { get; set; } = string.Empty;
        public String Indirizzo_Di_Consegna { get; set; } = string.Empty;
        public List<int> Contenuto { get; set; }
        public Ordine ToEntity()
        {
            Ordine ordine = new Ordine(MailCreatore, Indirizzo_Di_Consegna);

            return ordine;
        }
    }
}

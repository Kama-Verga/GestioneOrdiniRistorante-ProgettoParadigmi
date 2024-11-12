using GestioneOrdiniRistorante.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using GestioneOrdiniRistorante.Models;
using GestioneOrdiniRistorante.Models.Models.Request;
using GestioneOrdiniRistorante.Application.Service.Interface;


namespace GestioneOrdiniRistorante.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OridineController : Controller
    {
        private readonly ServiceOrdineInt OrInt;
        ServiceOrdine Or;
        public OridineController(ServiceOrdineInt IntTemp) 
        { 
            OrInt = IntTemp;
        }

        private List<Prodotto> IntToProdotto (String Con)
        {
            List<Prodotto> T = new List<Prodotto>();
            


            /*
            foreach (String t in i)
            {
                
            }*/

            return T;
        }


        [HttpPost]
        [Route("Crea-Ordine")]
        [Description("i piatti vanno separati da una /")]
        public String Creazione(int Creatore, String Contenuto)
        {
            List<Prodotto> T = IntToProdotto(Contenuto);
            Utente a = new Utente(null, null, null, null, 0); //prendere questo utente dal token del login
            return "0k - ";
        }
    }
}

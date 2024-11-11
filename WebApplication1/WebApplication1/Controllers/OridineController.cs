using GestioneOrdiniRistorante.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using GestioneOrdiniRistorante.Models;
using GestioneOrdiniRistorante.Request;
using GestioneOrdiniRistorante.Application.Service.Interface;


namespace GestioneOrdiniRistorante.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OridineController : Controller
    {
        private readonly ServiceOrdineInt OrInt;
        ServiceOrdine Or;
        List<Prodotto> Menu;
        public OridineController(ServiceOrdineInt IntTemp) { 
            Menu = new List<Prodotto> {
                new Prodotto { Id = 1,  Nome = "Pasta alla Bolognese", Prezzo = 8.99, Tipo = Portata.Primo},
                new Prodotto { Id = 2,  Nome = "Pasta Carbonara", Prezzo = 10.50, Tipo = Portata.Primo},
                new Prodotto { Id = 3,  Nome = "Tagliatelle ai funghi porcini", Prezzo = 9.99, Tipo = Portata.Primo},
                new Prodotto { Id = 4,  Nome = "Lasagna alla bolognese", Prezzo = 8.50, Tipo = Portata.Primo},
                new Prodotto { Id = 5,  Nome = "Spaghetti alle vongole", Prezzo = 10.50, Tipo = Portata.Primo},
                new Prodotto { Id = 6,  Nome = "Bistecca alla fiorentina", Prezzo = 14.99, Tipo = Portata.Secondo},
                new Prodotto { Id = 7,  Nome = "Pollo alla cacciatora", Prezzo = 10.99, Tipo = Portata.Secondo},
                new Prodotto { Id = 8,  Nome = "Branzino al forno con patate", Prezzo = 14.99, Tipo = Portata.Secondo},
                new Prodotto { Id = 9,  Nome = "Scaloppine al limone", Prezzo = 10.99, Tipo = Portata.Secondo},
                new Prodotto { Id = 10, Nome = "Agnello arrosto con erbe aromatiche", Prezzo = 12.99, Tipo = Portata.Secondo},
                new Prodotto { Id = 11, Nome = "Patate al forno", Prezzo = 2.99, Tipo = Portata.Contorno},
                new Prodotto { Id = 12, Nome = "Insalata mista", Prezzo = 2.99, Tipo = Portata.Contorno},
                new Prodotto { Id = 13, Nome = "Zucchine grigliate", Prezzo = 2.99, Tipo = Portata.Contorno},
                new Prodotto { Id = 14, Nome = "Verdure saltate in padella", Prezzo = 2.99, Tipo = Portata.Contorno},
                new Prodotto { Id = 15, Nome = "Purè di patate", Prezzo = 2.99, Tipo = Portata.Contorno},
                new Prodotto { Id = 16, Nome = "Tiramisù", Prezzo = 4.99, Tipo = Portata.Dolce},
                new Prodotto { Id = 17, Nome = "Panna cotta ai frutti di bosco", Prezzo = 4.99, Tipo = Portata.Dolce},
                new Prodotto { Id = 18, Nome = "Cheesecake al limone", Prezzo = 4.99, Tipo = Portata.Dolce},
                new Prodotto { Id = 19, Nome = "Torta di mele", Prezzo = 4.99, Tipo = Portata.Dolce},
                new Prodotto { Id = 20, Nome = "Cannoli siciliani", Prezzo = 4.99, Tipo = Portata.Dolce},
            };

            OrInt = IntTemp;


        }


        [HttpGet]
        [Route("Menù")]
        public IActionResult PostMenu()
        {
            return Ok(Menu + "\n" + "con il numero 0 si completa e si invia l'ordine");
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

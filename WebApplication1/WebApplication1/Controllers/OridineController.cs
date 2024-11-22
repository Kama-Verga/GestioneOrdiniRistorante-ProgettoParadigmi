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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using GestioneOrdiniRistorante.Models.Models.DTO;
using GestioneOrdiniRistorante.Models.Models.Responses;


namespace GestioneOrdiniRistorante.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OridineController : Controller
    {
        private readonly ServiceOrdineInt OrdineS;
        private readonly ServiceProdottoInt ProdottoS;

        public OridineController(ServiceOrdineInt IntTemp, ServiceProdottoInt IntTemp2) 
        {
            OrdineS = IntTemp;
            ProdottoS = IntTemp2;
        }


        [HttpPost]
        [Route("CreaOrdine")]
        public async Task<IActionResult> CreaOrdine(CreaOrdineReq T)
        {
            Ordine ordine = T.ToEntity();
            ordine.MailCreatore = "string";

            List<Prodotto> LP = new List<Prodotto>();

            foreach (int prodottoId in T.Contenuto)
            {
                // Recupera il prodotto
                Prodotto prodotto = await ProdottoS.TrovaProdotto(prodottoId);

                LP.Add(prodotto);

                // Aggiungi il prodotto all'ordine
                ordine.AggiungiProdotto(prodotto);
            }

            ordine.Prezzo = CalcolaTotaleConSconto(LP);

            // Salva l'ordine
            await OrdineS.CreaOrdine(ordine);

            // Crea la risposta
            var response = new CreaOrdineRes
            {
                Ordine = new OrdineDTO(ordine)
            };

            return Ok(response);
        }

        public static decimal CalcolaTotaleConSconto(List<Prodotto> prodotti)
        {
            decimal totale = 0;

            // Raggruppiamo i prodotti per tipo
            var gruppi = prodotti.GroupBy(p => p.Tipo);

            // Per ogni gruppo applicare lo sconto del 10%
            foreach (var gruppo in gruppi)
            {
                // Calcoliamo la somma del gruppo
                decimal sommaGruppo = gruppo.Sum(p => p.Prezzo);

                // Applichiamo lo sconto del 10% al gruppo
                decimal sommaScontata = sommaGruppo * 0.9m;

                // Aggiungiamo al totale
                totale += sommaScontata;
            }

            return totale;
        }




    }
}

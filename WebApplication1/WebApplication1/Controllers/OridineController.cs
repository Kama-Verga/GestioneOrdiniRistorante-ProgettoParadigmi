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
        int Numero_Ordine;

        public OridineController(ServiceOrdineInt IntTemp, ServiceProdottoInt IntTemp2) 
        {
            Numero_Ordine = 0;
            OrdineS = IntTemp;
            ProdottoS = IntTemp2;
        }


        [HttpPost]
        [Route("CreaOrdine")]
        public async Task<IActionResult> CreaOrdine(CreaOrdineReq T)
        {
            Numero_Ordine++;
            Ordine Tr = T.ToEntity(Numero_Ordine);
            Tr.MailCreatore = "string";

            decimal Tprezzo = 0;
            foreach (int item in T.Contenuto) {
                Prodotto PT = await ProdottoS.TrovaProdotto(item);
                Tr.AggiungiProdotto(PT);
                Tprezzo = Tprezzo + PT.Prezzo;
            }
            Tr.Prezzo = Tprezzo;

            OrdineS.CreaOrdine(Tr);
            var Ris = new CreaOrdineRes();
            Ris.Ordine = new OrdineDTO(Tr);
            return Ok(Ris);

        }
    }
}

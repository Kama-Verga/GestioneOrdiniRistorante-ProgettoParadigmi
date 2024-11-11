using GestioneOrdiniRistorante.Models;
using GestioneOrdiniRistorante.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using GestioneOrdiniRistorante.Application.Service.Interface;
using GestioneOrdiniRistorante.Application.Models.Request;
using GestioneOrdiniRistorante.Application.Service;

namespace GestioneOrdiniRistorante.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtenteController : Controller
    {
        private readonly ServiceUtenteInt UtenteS;

        public UtenteController(ServiceUtenteInt UsI)
        {
            UtenteS = UsI;
        }

        [HttpPost]
        [Route("Crea-Utente")]  // Nome specifico per questo POST
        // 0 = Utente - 1 = amministratore
        public String CreaUtente(CreaUtenteReq T)
        {
            UtenteS.CreaUtente(T.ToEntity());
            return "0k";
        }


    }
}

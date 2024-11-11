﻿using GestioneOrdiniRistorante.Application.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using GestioneOrdiniRistorante.Application.Models.Request;
using GestioneOrdiniRistorante.Application.Models.Responses;
using GestioneOrdiniRistorante.Application.Models.DTO;
using GestioneOrdiniRistorante.Application.Service;
using System.ComponentModel.Design;

namespace GestioneOrdiniRistorante.Web.Controllers
{
    public class ProdottoController : Controller
    {
        private readonly ServiceProdottoInt ProdottoS;

        public ProdottoController(ServiceProdottoInt PsI)
        {
            ProdottoS = PsI;
        }

        [HttpGet]
        [Route("Menù")]
        public async Task<IActionResult> PostMenu()
        {
            var Ris = new MenuRes();
            Ris.Menu = new MenuDTO(ProdottoS.Menu());
            return Ok(Ris);
        }
    }
}
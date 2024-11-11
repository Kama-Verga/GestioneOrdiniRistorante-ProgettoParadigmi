﻿using GestioneOrdiniRistorante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante.Application.Service.Interface
{
    public interface ServiceOrdineInt
    {
        Ordine CreaOrdine();

        List<Ordine> TrovaOrdiniDaUtente(Utente a);
        List<Ordine> TrovaOrdini();

    }
}
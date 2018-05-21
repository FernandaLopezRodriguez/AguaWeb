using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
           
            int botellasXDia = minutos * 12;
            DateTime hoy = DateTime.Today;
            TimeSpan lapsoHoyProximoCumple = ProximoCumple - hoy;
            int dias = lapsoHoyProximoCumple.Days;
            int totaBotellas = dias * botellasXDia;
            int meses = lapsoHoyProximoCumple.Days/30;
            int MesBotella = meses * botellasXDia;

            ViewBag.Dias = dias;
            ViewBag.Botellas = totaBotellas;
            ViewBag.Meses = meses;
            ViewBag.BotellasMes = MesBotella;

            return View();
        }

    }
}
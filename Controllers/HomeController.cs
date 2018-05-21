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
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 

            int botellasXDia = minutos * 12;
            DateTime hoy = DateTime.Today;
            TimeSpan lapsoHoyProximoCumple = ProximoCumple - hoy;
            int dias = lapsoHoyProximoCumple.Days;
            int totaBotellas = dias * botellasXDia;


            ViewBag.Dias = dias;
            ViewBag.Botellas = totaBotellas;

            return View();
        }

    }
}
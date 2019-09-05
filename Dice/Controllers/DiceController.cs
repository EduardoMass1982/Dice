using Dice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dice.Controllers
{
    public class DiceController : Controller
    {
        public static int cantidadGano1 = 0;
        public static int cantidadGano2 = 0;
        public static int cantidadEmpate = 0;

        public ActionResult Index(JugadoresModel modelo)
        {
            //JugadoresModel modelo = new JugadoresModel()
            //{
            //    NombreJugador1 = _NombreJugador1,
            //    NombreJugador2 = _NombreJugador2
            //};
            return View(modelo);
        }
        /// 0 = Empate
        /// 1 = Gano 1
        /// 2 = Gano 2
        [HttpGet]
        public void PostResultado(int resultado)
        {
            
            if (resultado == 0)
                DiceController.cantidadEmpate++;
            if (resultado == 1)
                DiceController.cantidadGano1++;
            if (resultado == 2)
                DiceController.cantidadGano2++;
                
        }
    }
}
using Dice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dice.Controllers
{
    public class EstadisticasController : Controller
    {
        // GET: Estadisticas
        private EstadisticaModel ObtenerModelo()
        {
            EstadisticaModel estadisticaModelo =
                new EstadisticaModel();
            estadisticaModelo.CantidadEmpates =
                DiceController.cantidadEmpate;
            estadisticaModelo.CantidadJugador1 =
                DiceController.cantidadGano1;
            estadisticaModelo.CantidadJugador2 =
                DiceController.cantidadGano2;

            estadisticaModelo.Porcentaje1Calculado = "Fede lo calculo asi :" +
               Math.Round( (decimal)estadisticaModelo.CantidadJugador1 * 100 /
                (decimal)estadisticaModelo.Total, 4);

            return estadisticaModelo;
        }
        public ActionResult Resultados()
        {
            return View(this.ObtenerModelo());
        }
        public ActionResult Resultados2()
        {
            return View(this.ObtenerModelo());
        }
        public ActionResult Resultados3(int valor)
        {
            if (valor == 1)
                return View("Resultados", this.ObtenerModelo());
            if (valor == 2)
                return View("Resultados2", this.ObtenerModelo());
            return View(this.ObtenerModelo());
        }
    }
}
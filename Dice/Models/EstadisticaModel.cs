using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dice.Models
{
    public class EstadisticaModel
    {

        public string Porcentaje1Calculado { get; set; }

        public int CantidadJugador1 { get; set; }
        public int CantidadJugador2 { get; set; }
        public int CantidadEmpates { get; set; }
        public int Total {
            get
            {
                return this.CantidadJugador1 +
                    this.CantidadJugador2 +
                    this.CantidadEmpates;
            }
        }
        public decimal CalcularPorcentajeBien(int valor,
            int total)
        {
            if (total == 0)
                return 0;
            return Math.Round( ((decimal)valor / (decimal)total) * 100, 2);
        }
        
        public decimal Porcentaje1
        {
            get
            {
                return this.CalcularPorcentajeBien(this.CantidadJugador1,
                    this.Total);
            }
        }
        public decimal Porcentaje2
        {
            get
            {
                return this.CalcularPorcentajeBien(this.CantidadJugador2,
                    this.Total);
            }
        }
        public decimal PorcentajeEmpate
        {
            get
            {
                return this.CalcularPorcentajeBien(this.CantidadEmpates,
                    this.Total);
            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FiGloo
{
    public class Gerente : EmpleadoTiempoCompleto, IEvaluable
    {
        private double bonoPorEquipo;
        private int cantidadIntegrantes;

        public Gerente(double salario, double bonoPorEquipo, int cantidadIntegrantes ) : base(salario)
        {
            this.bonoPorEquipo = bonoPorEquipo;
            this.cantidadIntegrantes = cantidadIntegrantes;
        }

        public override double CalcularPago()
        {
            return base.CalcularPago() + bonoPorEquipo;
        }

        public override void MostrarInfo()
        {
            Empleado baseRef = this;     
            baseRef.GetType();           
            Console.WriteLine($" {nombre} — Gerente");
            Console.WriteLine($"  Pago: ${CalcularPago():F2}  ({(CalcularPago() - bonoPorEquipo):F2} + {bonoPorEquipo:F2})");
            Console.WriteLine($"  Equipo: {cantidadIntegrantes} personas");
            
        }

        public string Evaluar ()
        {
            if (cantidadIntegrantes >= 5)
                return $"Excelente — equipo de {cantidadIntegrantes} personas bien gestionado.";
            else if (cantidadIntegrantes >= 2)
                return $"Bueno — equipo de {cantidadIntegrantes} personas en crecimiento.";
            else
                return $"Regular — equipo muy pequeño ({cantidadIntegrantes} persona).";
        }
    }
}

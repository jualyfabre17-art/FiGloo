using System;
using System.Collections.Generic;
using System.Text;

namespace FiGloo
{
    public class EmpleadoPorHoras : Empleado
    {
        protected double tarifaPorHora;
        protected int horasTrabajadas;

        public EmpleadoPorHoras (double salario,string nombre, double tarifaPorHora, int horasTrabajadas) : base(nombre, salario) 
        {
            
            this.tarifaPorHora = tarifaPorHora;
            this.horasTrabajadas = horasTrabajadas;
        }
        public override double CalcularPago()
        {
            return tarifaPorHora * horasTrabajadas;
        }
    }
}

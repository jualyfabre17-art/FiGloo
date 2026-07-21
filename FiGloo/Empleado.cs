using System;
using System.Collections.Generic;
using System.Text;

namespace FiGloo
{
    public abstract class Empleado
    {
        protected string nombre;
        protected double salario;
        

        public Empleado ( string nombre,double salario) {
            
            this.nombre = nombre;
            this.salario = salario;
            
        }

        public abstract double CalcularPago();

        public virtual void MostrarInfo()
        {
            Console.WriteLine( $"El nombre del empleado es {nombre}");
            Console.WriteLine($"Salario {salario}");
            
        }


    }
}

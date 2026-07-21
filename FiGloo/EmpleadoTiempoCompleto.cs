using System;
using System.Collections.Generic;
using System.Text;

namespace FiGloo
{
    public class EmpleadoTiempoCompleto : Empleado
    {
        

        public EmpleadoTiempoCompleto(double salario, string nombre) : base( nombre, salario) 
        {
            this.nombre = nombre;
            this.salario = salario;
        
        }

        public override double CalcularPago()
        {
             
            return 0.0;
        }

        public override void MostrarInfo()
        {
            
            base.MostrarInfo();
            Console.WriteLine( $" *Es un buen empleado");
        }
    }
}

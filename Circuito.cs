using System;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace taller2
{
    public class Circuito
    {
        Vehiculo? Vehiculo { get; set; }

        public int VueltasPermitidas { get; set; }
         public String NombreDelCircuito { get; set; }
           public void AñadirVehiculo(Vehiculo vehiculo)
        {
            this.Vehiculo = vehiculo;
        }

        public Circuito(int VueltasPermitidas, String NombreDelCircuito)
        {
            this.VueltasPermitidas = VueltasPermitidas;
            this.NombreDelCircuito = NombreDelCircuito;
        }
        public void SacarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                this.Vehiculo = vehiculo;
            }
            catch
            {
                Console.WriteLine("El vehiculo no esta en este circuito");
            }
        }
             
        public int RealizarPrueba()
        {
            if (this.Vehiculo == null )
            {
                 throw new ArgumentException("No hay vehiculos");
            }
            int fastest = 1000000;
  
                this.Vehiculo.Encender();
                this.Vehiculo.Movimiento();

                for(int i = 0; i < this.VueltasPermitidas; i++)
                { 
                    Random r = new Random();
                    int lap = r.Next(0,1000);
                    if (lap < fastest)
                    {
                        fastest = lap;
                    }
                }               
                Console.WriteLine($"Vehiculo {this.Vehiculo.Escuderia} con el lap {fastest}");
                this.Vehiculo.Detener();
                this.Vehiculo.Apagar();            
            return fastest;
     
        }

    }
}

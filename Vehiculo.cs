using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static taller2.IVehiculo;
using System.Collections.Generic;


namespace taller2
{
    public enum Estado
    {
        APAGADO,
        ENCENDIDO, 
        MOVIMIENTO, 
        PARADO
    }

    public class Vehiculo : IVehiculo
    {
        
        public string Tipo { get; set; }
        public string Escuderia { get; set; }
        public List<Estado> Estado { get; private set; } = new List<Estado>();

        public Vehiculo(string tipo, string escuderia)
        {
            this.Tipo = tipo;
            this.Escuderia = escuderia;
            this.Estado.Add(taller2.Estado.APAGADO);
        }

        public void Encender()
        {
            if (this.Estado.Contains(taller2.Estado.APAGADO)) {
                this.Estado.Clear();
                this.Estado.Add(taller2.Estado.ENCENDIDO);
                this.Estado.Add(taller2.Estado.PARADO);
                Console.WriteLine($"Encendiendo {this.Tipo}");
                return;
            }

            Console.WriteLine("Debes apagar el vehiculo");
        }

        public void Apagar()
        {
            if (this.Estado.Contains(taller2.Estado.ENCENDIDO) && this.Estado.Contains(taller2.Estado.PARADO))
            {
                this.Estado.Clear();
                this.Estado.Add(taller2.Estado.APAGADO);
                Console.WriteLine($"Apagando {this.Tipo}");

                return;
                Environment.Exit(0);
            }

            Console.WriteLine("El vehiculo se apago");

        }
           public void Detener()
        {
            if (this.Estado.Contains(taller2.Estado.ENCENDIDO) && this.Estado.Contains(taller2.Estado.MOVIMIENTO))
            {
                this.Estado.Clear();
                this.Estado.Add(taller2.Estado.PARADO);
                this.Estado.Add(taller2.Estado.ENCENDIDO);
                Console.WriteLine($"Parando {this.Tipo}");
                return;
            }

            Console.WriteLine("El vehiculo debe estar encendido y en movimiento");

        }

        public void Movimiento()
        {
            if (this.Estado.Contains(taller2.Estado.ENCENDIDO) && this.Estado.Contains(taller2.Estado.PARADO))
            {
                this.Estado.Clear();
                this.Estado.Add(taller2.Estado.MOVIMIENTO);
                this.Estado.Add(taller2.Estado.ENCENDIDO);
                Console.WriteLine($"{this.Tipo} en movimiento");
                return;
                Environment.Exit(0);
            }

            Console.WriteLine("El vehiculo debe estar encendido y parado");       
        }
     
    }

    
}

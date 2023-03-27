using System;
using System.Text;
using System.Linq;

using System.Threading.Tasks;
using System.Collections.Generic;

namespace taller2
{
    public interface IVehiculo
    {
        public void Encender();
        public void Apagar();
        public void Movimiento();
        public void Detener();
    }
}

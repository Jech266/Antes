using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgramacion
{
    internal class operaciones
    {
        
        public operaciones()
        {

        }
        int cartera = 2500;
        public int operacion(int cartera)
        {
            return cartera;
        }
        public int operacion(int monto, int cartera)
        {
            cartera = cartera - monto;
            return cartera;
        }
        public int operacion(int monto, int cartera, int cuenta)
        {
            cartera = cartera - monto;
            return cartera;
        }
    }
}

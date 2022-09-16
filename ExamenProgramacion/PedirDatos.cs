using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgramacion
{
    internal class PedirDatos
    {
        public PedirDatos()
        { 

        }
        public void solicitardatos()  
        {
            int NIP = 1234; 
           
            for (int i = 0; i <= 3;)
            
            {  
                Console.WriteLine("Ingresar tu tarjeta y NIP");
                NIP = int.Parse(Console.ReadLine());
                if (NIP == 1234)
                {
                    Console.Clear();
                    i = 5;
                }
                if (NIP != 1234)
                {
                    Console.WriteLine("NIP incorrecto, intentelo denuevo");
                    i++;
                }
                if (i == 3)
                {
                    Console.WriteLine("Haz superado tus intentos, regresa en una hora");
                    Environment.Exit(0);
                }
            }
        }
        operaciones op = new operaciones();
        public int Operaciones()
        {
            string opcion, seguir;
            int monto = 0, cartera = 2500, resultado = 0, cuenta;
            do
            {
                Console.WriteLine("Seleccionar operacion a realizar");
                Console.WriteLine("1 consulta saldo");
                Console.WriteLine("2 retira efectivo");
                Console.WriteLine("3 deposito");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Consulta de saldo");
                        resultado = op.operacion(cartera);
                        Console.WriteLine("Tu cartera: $ {0}", resultado);
                        break;

                    case "2":
                        Console.WriteLine("dinero a retira");
                        monto = int.Parse(Console.ReadLine());
                        resultado = op.operacion(monto, cartera);
                        Console.WriteLine("Transaccion exitosa su saldo es: ${0} ", resultado);
                        break;
                    case "3":
                        Console.WriteLine("dinero a depositar");
                        monto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Numero de cuenta a depositar");
                        cuenta = int.Parse(Console.ReadLine());
                        resultado = op.operacion(monto, cartera, cuenta);
                        Console.WriteLine("Transaccion exitora su saldo es de: ${0}", resultado);
                        break;
                    default:
                        Console.WriteLine("Operacion no encontrada.");
                        break;
                }
                Console.WriteLine("Desea realizar otra operacion");
                seguir = Console.ReadLine();
            } while (seguir == "si" || seguir == "SI");
            return cartera;

        }
        public void despedir()
        {
            Console.Clear();
            Console.WriteLine("gracias por usar el cajero");
        }
    }
}

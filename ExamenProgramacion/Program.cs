using System;

namespace ExamenProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedirDatos ob = new PedirDatos();

            ob.solicitardatos();

            ob.Operaciones();

            ob.despedir();

        }
    }
}

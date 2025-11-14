using System;

namespace CajeroLitePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(1, "Daniel", 1234, 500000);
            Cajero cajero = new Cajero(usuario);
            cajero.Iniciar();
        }
    }
}

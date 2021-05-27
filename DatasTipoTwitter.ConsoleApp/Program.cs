using System;
using DatasTipoTwitter.ConsoleApp;

namespace DatasTipoTwitter
{
    public class Program
    {
        static Passado passado = new Passado();

        static void Main()
        {
            passado.ValidarDatas();
            Console.ReadKey();
        }
    }
}


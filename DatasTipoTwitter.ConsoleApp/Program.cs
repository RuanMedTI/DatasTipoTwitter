using System;

namespace DatasTipoTwitter
{
    public class Program
    {
        static Passado passado = new Passado();

        static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Datas tipo Twitter 1.1");
            Console.ResetColor();

            DateTime dateTime = new DateTime(2021, 04, 28, 17, 00, 00);

            DateTime dataAgora = new DateTime(2021, 05, 27, 14, 00, 00);

            string tempoPassado = "";

            if (dateTime > dataAgora)
                tempoPassado = "A data e hora inserida é futura, tente novamente!";
            else
            {
                Passado passado = new Passado();
                tempoPassado += passado.ValidarDatas(dateTime, dataAgora);
            }

            Console.WriteLine(tempoPassado.ToUpper());
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasTipoTwitter.ConsoleApp
{
    public class Passado : Dicionario
    {

        public string ValidarDatas(DateTime d)
        {
            DatasInseridas();

            TimeSpan s = DateTime.Now.Subtract(d);

            int dayDiff = (int)s.TotalDays;

            int secDiff = (int)s.TotalSeconds;

            if (dayDiff < 0 || dayDiff >= 31)
            {
                return null;
            }

            if (dayDiff == 0)
            {

                if (secDiff < 60)
                {
                    return "Agora mesmo";
                }

                if (secDiff < 120)
                {
                    return "Um minuto atrás";
                }

                if (secDiff < 3600)
                {
                    return string.Format("{0} minutos atrás",
                        Math.Floor((double)secDiff / 60));
                }

                if (secDiff < 7200)
                {
                    return "Uma hora atrás";
                }

                if (secDiff < 86400)
                {
                    return string.Format("{0} horas atrás",
                        Math.Floor((double)secDiff / 3600));
                }
            }

            if (dayDiff == 1)
            {
                return "ontem";
            }
            if (dayDiff < 7)
            {
                return string.Format("{0} dias atrás",
                    dayDiff);
            }
            if (dayDiff < 31)
            {
                return string.Format("{0} semanas atrás",
                    Math.Ceiling((double)dayDiff / 7));
            }
            return null;
        }

        private void DatasInseridas()
        {
            Console.WriteLine(ValidarDatas(DateTime.Parse("2011, 05, 11")));

            /*Console.WriteLine(ValidarDatas(DateTime.Now.AddSeconds(-90)));
            Console.WriteLine(ValidarDatas(DateTime.Now.AddMinutes(-25)));
            Console.WriteLine(ValidarDatas(DateTime.Now.AddMinutes(-45)));
            Console.WriteLine(ValidarDatas(DateTime.Now.AddHours(-4)));
            Console.WriteLine(ValidarDatas(DateTime.Now.AddDays(-15)));*/
        }
    }
}


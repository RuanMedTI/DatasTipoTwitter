using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasTipoTwitter.ConsoleApp
{
    public class Passado : Dicionario
    {
        public string ValidarDatas()
        {
            const int SEGUNDO = 1;
            const int MINUTO = 60 * SEGUNDO;
            const int HORA = 60 * MINUTO;
            const int DIA = 24 * HORA;
            const int MES = 30 * DIA;

            DateTime Data1 = new DateTime(2020, 12, 08);

            var ts = new TimeSpan(DateTime.UtcNow.Ticks - Data1.Ticks);
            double dataValida = Math.Abs(ts.TotalSeconds);

            if (dataValida < 1 * MINUTO)
                return ts.Seconds == 1 ? "um segundo atrás" : ts.Seconds + " segundos atrás";

            else if (dataValida < 2 * MINUTO)
                return "um minuto atrás";

            else if (dataValida < 45 * MINUTO)
                return ts.Minutes + " minutos atrás";

            else if (dataValida < 90 * MINUTO)
                return "uma hora atrás";

            else if (dataValida < 24 * HORA)
                return ts.Hours + " horas atrás";

            else if (dataValida < 48 * HORA)
                return "ontem";

            else if (dataValida < 30 * DIA)
                return ts.Days + " dias atrás";

            else if (dataValida < 12 * MES)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "um mês atrás" : months + " meses atrás";
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "um ano atrás" : years + " anos atrás";
            }
        }
    }
}


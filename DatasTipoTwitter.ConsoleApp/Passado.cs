using System;

namespace DatasTipoTwitter
{
    
    internal class Passado
    {
        internal string ValidarDatas(DateTime dateTime, DateTime dataAgora)
        {
            string[] numeros = new[] { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete",
            "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis",
            "dezessete", "dezoito", "dezenove", "vinte", "vinte e um", "vinte e dois", "vinte e três",
            "vinte e quatro", "vinte e cinco", "vinte e seis", "vinte e sete", "vinte e oito",
            "vinte e nove", "trinta", "trinta e um", "trinta e dois", "trinta e três", "trinta e quatro",
            "trinta e cinco", "trinta e seis", "trinta e sete", "trinta e oito", "trinta e nove",
            "quarenta", "quarenta e um", "quarenta e dois", "quarenta e três", "quarenta e quatro",
            "quarenta e cinco", "quarenta e seis", "quarenta e sete", "quarenta e oito",
            "quarenta e nove", "cinquenta", "cinquenta e um", "cinquenta e dois", "cinquenta e três",
            "cinquenta e quatro", "cinquenta e cinco", "cinquenta e seis", "cinquenta e sete",
            "cinquenta e oito", "cinquenta e nove", "sessenta",
            }; 

            string result = string.Empty;
            var timeSpan = DateTime.Now.Subtract(dateTime);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                result = string.Format("{0} segundos atrás", timeSpan.Seconds);
            }
            else if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                result = timeSpan.Minutes > 1 ?
                    string.Format("há {0} minutos atrás", timeSpan.Minutes) :
                    "há um minuto atrás";
            }
            else if (timeSpan <= TimeSpan.FromHours(24))
            {
                result = timeSpan.Hours > 1 ?
                    string.Format("há {0} horas atrás", timeSpan.Hours) :
                    "há uma hora atrás";
            }
            else if (timeSpan <= TimeSpan.FromDays(30))
            {
                result = timeSpan.Days > 1 ?
                    string.Format("há {0} dias atrás", timeSpan.Days) :
                    "ontem";
            }
            else if (timeSpan <= TimeSpan.FromDays(365))
            {
                result = timeSpan.Days > 30 ?
                    string.Format("há {0} meses atrás", timeSpan.Days / 30) :
                    "há um mês atrás";
            }
            else
            {
                result = timeSpan.Days > 365 ?
                    string.Format("há {0} anos atrás", timeSpan.Days / 365) :
                    "há um ano atrás";
            }

            return numeros + result;
        }
    }
}



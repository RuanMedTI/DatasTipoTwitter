using System;
using System.Collections.Generic;
using System.Text;

namespace DatasTipoTwitter.ConsoleApp
{
    public class Dicionario
    {
        public static Dictionary<long, string> unidadesExtenso = new Dictionary<long, string>()
        {
            { 1, "um" },
            { 2, "dois" },
            { 3, "tres" },
            { 4, "quatro" },
            { 5, "cinco" },
            { 6, "seis" },
            { 7, "sete" },
            { 8, "oito" },
            { 9, "nove" },
        };

        public static Dictionary<long, string> dezenasExtenso = new Dictionary<long, string>()
        {
            { 10, "dez" },
            { 11, "onze" },
            { 12, "doze" },
            { 13, "treze" },
            { 14, "catorze" },
            { 15, "quinze" },
            { 16, "dezesseis" },
            { 17, "dezessete" },
            { 18, "dezoito" },
            { 19, "dezenove" },
            { 2, "vinte" },
            { 3, "trinta" },
            { 4, "quarenta" },
            { 5, "cinquenta" },
            { 6, "sessenta" },
            { 7, "setenta" },
            { 8, "oitenta" },
            { 9, "noventa" },
        };

        public static Dictionary<long, string> centenasExtenso = new Dictionary<long, string>()
        {
            { 1, "cento" },
            { 2, "duzentos" },
            { 3, "trezentos" },
            { 4, "quatrocentos" },
            { 5, "quinhentos" },
            { 6, "seiscentos" },
            { 7, "setecentos" },
            { 8, "oitocentos" },
            { 9, "novecentos" },
        };

        public static Dictionary<long, Dictionary<long, string>> dicionariosPorUnidadeDeCentena =
            new Dictionary<long, Dictionary<long, string>>()
        {
            {1, unidadesExtenso },
            {2, dezenasExtenso },
            {3, centenasExtenso }
        };

        public static Dictionary<string, string> prefixosDeSegundosEmStringSingular =
            new Dictionary<string, string>()
            {
                {"SEGUNDO", "segundo" },
                {"MINUTO", "minuto" },
                {"HORA", "hora" },
            };

        public static Dictionary<string, string> prefixosDeSegundosEmStringPlural =
            new Dictionary<string, string>()
            {
                {"SEGUNDO", "segundos" },
                {"MINUTO", "minutos" },
                {"HORA", "horas" },
            };

        public static Dictionary<string, string> prefixosDeDiasEmStringSingular =
            new Dictionary<string, string>()
            {
                {"DIA", "dia" },
                {"SEMANA", "semana" },
                {"MES", "mes" },
                {"ANO", "ano" },
            };

        public static Dictionary<string, string> prefixosDeDiasEmStringPlural =
            new Dictionary<string, string>()
            {
                {"DIA", "dias" },
                {"SEMANA", "semanas" },
                {"MES", "meses" },
                {"ANO", "anos" },
            };
    }
}
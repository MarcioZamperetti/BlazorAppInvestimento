using System;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components;

namespace BlazorAppInvestimentos.Data
{
    enum Format
    {
        Currency,
        Percent,
        None
    }
    public class calculosJurosCompostos : ComponentBase
    {
        public double valorInicial { get; set; }
        public double aporteMensal { get; set; }
        public double numeroDeMeses { get; set; }
        public double jurosMensais { get; set; }

        public double montante { get; set; }
        public double investimentoTotal { get; set; }
        public double jurosTotal { get; set; }

        public string valorInicialString { get; set; } = "";
        public string aporteMensalString { get; set; } = "";
        public string numeroDeAnosString { get; set; } = "";
        public string jurosAnualString { get; set; } = "";

        public string montanteTotal { get; set; } = "";
        public string aportesTotais { get; set; } = "";
        public string jurosTotais { get; set; } = "";


        public void CalculaMontante()
        {
            double juros = jurosMensais / 100;

            montante = valorInicial;
            for (int i = 1; i <= numeroDeMeses; i++)
            {
                montante += aporteMensal + (montante * juros);
            }

            investimentoTotal = valorInicial + (aporteMensal * numeroDeMeses);
            jurosTotal = montante - investimentoTotal;
        }
    }
    
}

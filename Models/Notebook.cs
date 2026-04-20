using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAtivosTI.Models
{
    public class Notebook(string numeroSerie, string marca, decimal valorAquisicao, double tamanhoTelaPolegadas) : Equipamento(numeroSerie, marca, valorAquisicao)
    {
        public double tamanhoTelaPolegadas { get; set; } = tamanhoTelaPolegadas;
        public override decimal CalcularDepreciacao(int anosDeUso)
        {
            decimal taxaDepreciacao = ValorAquisicao * 0.20m;
            decimal desgasteBateria = 150.0m * anosDeUso;
            decimal depreciacaoTotal = (taxaDepreciacao * anosDeUso) + desgasteBateria;
            return Math.Min(depreciacaoTotal, ValorAquisicao);
        }

        public override string ObterDescricao() => $"{base.ObterDescricao()} | Tela: {tamanhoTelaPolegadas}\"";

    }
}

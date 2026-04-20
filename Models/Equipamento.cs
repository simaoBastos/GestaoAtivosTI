using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GestaoAtivosTI.Models
{
    [JsonDerivedType(typeof(Notebook), typeDiscriminator:"notebook")]
    [JsonDerivedType(typeof(Servidor), typeDiscriminator:"servidor")]
    public abstract class Equipamento
    {
        public Guid Id { get; set; }
        public string NumeroSerie { get; set; }
        public string Marca { get; set; }

        private decimal _valorAquisicao;
        public decimal ValorAquisicao
        {
            get => _valorAquisicao;

            set
            {
                if (value < 0) throw new ArgumentException("O valor da aquisição não pode ser negativo.");
                _valorAquisicao = value;
            }
        }

        protected Equipamento (string numeroSerie, string marca,decimal valorAquisicao)
        {
            Id = Guid.NewGuid();
            NumeroSerie = numeroSerie;
            Marca = marca;
            ValorAquisicao = valorAquisicao;
        }

        public abstract decimal CalcularDepreciacao(int anosDeUso);
        public virtual string ObterDescricao() => $"[{NumeroSerie}] {Marca} - Comprado por: {ValorAquisicao:c2}";
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Fiap.Models
{
    class Clinica : Estabelecimento
    {
        public override decimal CalcularImposto(decimal faturamento)
        {
            // m para definir o tipo de dados de ponto flutuante -> decimal
            return faturamento * 0.065m;
        }
    }
}

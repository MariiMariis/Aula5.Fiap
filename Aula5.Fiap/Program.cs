using Aula5.Fiap.Models;
using System;

namespace Aula5.Fiap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando uma loja
            Loja loja = new Loja()
            {
                Cnpj = "12.123.123/0001-10",
                Nome = "FIAP Store",
                QuatidadeProdutos = 750,
                // Atribuir um valor para o tipo de enum
                Tipo = TipoLoja.Roupas
            };

            //Verifica se é uma loja de roupas
            if (loja.Tipo == TipoLoja.Roupas)
            {
                Console.WriteLine("É uma loja de roupas");
            }
            else
            {
                Console.WriteLine("Não é uma loja de roupas");
            }

            Console.WriteLine($"O imposto da loja é {loja.CalcularImposto(1750)}");
        }
    }
}

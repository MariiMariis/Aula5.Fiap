using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Fiap.Models
{
    abstract class Estabelecimento
    {
        public string Nome { get; set; }

        public string Cnpj { get; set; }

        //Método abstrato, sem implementação
        public abstract decimal CalcularImposto(decimal faturamento);

        public void CadastrarFuncionario(string nome)
        {
            Console.WriteLine($"Cadastrando funcionário {nome}, no estabelecimento {Nome}");
        }

        public bool ValidarCnpj()
        {
            if (Cnpj.Length < 20)
            {
                return false;
            }
            return true;
        }
    }
}

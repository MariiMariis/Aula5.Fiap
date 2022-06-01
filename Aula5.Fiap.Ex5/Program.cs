
using System;

namespace Aula5.Fiap.Ex5
{
    //Enum meses do ano, com valores pré determinados
    enum MesesAno
    {
        Janeiro = 1,
        Fevereiro,
        Marco,
        Abril,
        Maio,
        Junho,
        Julho,
        Agosto,
        Setembro,
        Outubro,
        Novembro,
        Dezembro

    };
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("O {0}º mês do ano é {1}",(int)MesesAno.Abril, MesesAno.Abril );

        }
    }
}

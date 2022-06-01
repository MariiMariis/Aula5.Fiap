using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Fiap.Ex5
{
    class Teste_enum
    {
        // Lista com itens pré determinados
        public enum Atletas
        {
            Daiane, Robinho, Ronaldo, Messi, Marta
        };

        static void Main(string[] args)
        {
            //Criação de contador para o loop
            int contador = 0;

            // Passará por cada item na lista do enumerate, e realizara uma ação contando cada ítem 
            foreach (Atletas atletas in Enum.GetValues(typeof(Atletas)))
            {
                contador++;
                // O método Write imprime o resultado na mesma linha
                Console.Write(contador + "º Lugar"+ "----");
                // o método writeline imprime um resultado e pula uma linha para imprimir o próximo
                Console.WriteLine(atletas);
            }
        }
    }
}

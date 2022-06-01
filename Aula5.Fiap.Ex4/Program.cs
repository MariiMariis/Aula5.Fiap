using Aula5.Fiap.Ex4.Models;
using System;

namespace Aula5.Fiap.Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando objetos à partir das classes
            Animais animal = new Animais();
            Animais gato = new Gato();
            Animais cachorro = new Cachorro();
            Gato gato1 = new Gato();

            animal.Som();
            gato.Som();
            cachorro.Som();
            gato1.Som();
        }
    }
}

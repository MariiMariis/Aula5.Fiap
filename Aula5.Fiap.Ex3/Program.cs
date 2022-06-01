using Aula5.Fiap.Ex3.Models;
using System;

namespace Aula5.Fiap.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia um objeto a partir da classe Circulo, e retorna no console o calculo de sua área
            Circulo circulo = new Circulo(5.0);
            Console.WriteLine($"Área do círculo: {circulo.Area()}");

            // Instancia um objeto a partir da classe Circulo, e retorna no console o calculo de sua área
            Quadrado quadrado = new Quadrado(1.74);
            Console.WriteLine($"Área do quadrado: {quadrado.Area()}");

            // Instancia um objeto a partir da classe Circulo, e retorna no console o calculo de sua área
            Triangulo triangulo = new Triangulo(2.7, 6.2);
            Console.WriteLine($"Área do triângulo: {triangulo.Area()}");

        }
    }
}

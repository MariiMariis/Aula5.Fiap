using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Fiap.Ex3.Models
{
    class Triangulo : Forma
    {

        //Criação de fields
        private double tbase;
        private double taltura;

        //Construtor que recebe 2 atributos 
        public Triangulo(double b, double h)
        {
            tbase = b;
            taltura = b;
        }

        // Método override que sobrescreve o método da classe Forma, para cálculo da área do triangulo
        public override double Area()
        {
            return (0.5 * tbase * taltura);
        }
    }
}

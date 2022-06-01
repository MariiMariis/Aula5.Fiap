using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Fiap.Ex3.Models
{
    class Quadrado : Forma
    {
        // Criação de field 
        private double lado;

        //Construtor
        public Quadrado(double l)
        {
            lado = l;
        }
        // Método override que sobrescreve o método da classe Forma, para cálculo da área do quadrado
        public override double Area()
        {
            return (lado * lado);
        }

    }
}

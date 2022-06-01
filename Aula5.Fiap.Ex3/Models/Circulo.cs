using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Fiap.Ex3.Models
{
    class Circulo : Forma
    {
        //Criação de fields
        private double radius;

        //Construtor que recebe um double 
        public Circulo(double r)
        {
            radius = r;
        }

        // Método override que sobrescreve o método da classe Forma, para cálculo da área do círculo
        // Utilizaremos 3.14 para calculo simplificado
        public override double Area()
        {
            return (3.14 * radius * radius);
        }
    }
}

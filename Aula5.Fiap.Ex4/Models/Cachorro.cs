using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Fiap.Ex4.Models
{
    class Cachorro : Animais
    {
        //Utilizar o modificador override, para que o método herdado sobrescreva o método da classe Pai.
        public override void Som()
            
        {
            Console.WriteLine("Este animal late.");
        }
    }
}

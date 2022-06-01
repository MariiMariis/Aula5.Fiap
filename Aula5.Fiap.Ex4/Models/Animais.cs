using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Fiap.Ex4.Models
{
    class Animais
    {
        //Classe base
        public virtual void Som()
            // Utilizar o modificador virtual, para que o método possa ser sobrescrito pelas classes filhas.
        {
            Console.WriteLine("Esse animal faz um som.");
        }
        
    }
}

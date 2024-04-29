using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set;}

        public Persona(string nome, string cognome) 
        {
            Nome = nome;
            Cognome = cognome;
        }
    }
}

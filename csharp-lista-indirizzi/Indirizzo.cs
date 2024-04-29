using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        //Bonus: iterare la lista di indirizzi e risalvarli in un file.
        //creo proprietà per la classe Indirizzo
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Indirizzo(string street, string city, string state, string zip)
        {
            
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            return $"======================{Environment.NewLine}Street: {Street},{Environment.NewLine}City: {City}{Environment.NewLine}State: {State}{Environment.NewLine}Zip (postal code): {Zip}";
        }
    }
}

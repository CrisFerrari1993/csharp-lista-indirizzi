using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        //Bonus: iterare la lista di indirizzi e risalvarli in un file.
        //creo proprietà per la classe Indirizzo
        public Persona Utente {  get; set; } 
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }



        public Indirizzo(string nomeUtente, string cognomeUtente ,string street, string city, string state, string zip)
        {
            Utente = new(nomeUtente, cognomeUtente);
            if (street.Length <= 1 || city.Length <= 1 || state.Length != 2 || zip.Length < 5)
                throw new ArgumentException("Il dato non ha un valore coerente");
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            return $"======================{Environment.NewLine}User name: [{Utente.Nome} {Utente.Cognome}]{Environment.NewLine}Street: {Street},{Environment.NewLine}City: {City}{Environment.NewLine}State: {State}{Environment.NewLine}Zip (postal code): {Zip}";
        }
    }
}

namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanzio una lista di indirizzi presi da un path e assegno il return della funzione come valore della lista
            List<Indirizzo> listaIndirizzi = LeggoFile("C:\\Users\\ferra\\Documents\\File\\addresses.csv");
            //stampo gli indirizzi presi dal file
            foreach(var indirizzo in listaIndirizzi)
            {
                Console.WriteLine(indirizzo);
            }

            // creo file per bonus
            var indirizzi = LeggoFile("C:\\Users\\ferra\\Documents\\File\\addresses.csv");
            StampaFileTesto(indirizzi, "C:\\Users\\ferra\\Documents\\File\\addresses.txt");
            
        }

        //Creo un metodo per leggere il file:
        static List<Indirizzo> LeggoFile(string path)
        {
            //inizializzo lista vuota
            List<Indirizzo> indirizzi = new List<Indirizzo>();
            
            //inizializzo var stream che sara il testo stesso
            var stream = File.OpenText(path);

            int i = 0;

            while(stream.EndOfStream == false)
            {
                var linea = stream.ReadLine();
                i++;
                if (i <= 1)
                    continue;
                try
                {
                    var dato = linea.Split(',');
                    //logica per inserire solo dati corretti (non proprio mega stringente...)
                    if (dato[2].Length > 1 && dato[3].Length > 1 && dato[4].Length == 2 && dato[5].Length >= 5)
                    {
                        string nomeUtente = dato[0];
                        string cognomeUtente = dato[1];
                        string street = dato[2];
                        string city = dato[3];
                        string state = dato[4];
                        string zip = dato[5];

                        Indirizzo indirizzo = new(nomeUtente, cognomeUtente, street, city, state, zip);
                        indirizzi.Add(indirizzo);
                    }  
                }
                //stampo tipo di errore in console
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            stream.Dispose();
            return indirizzi;
        }

        //Creazione metodo per passare gli indirizzi presi e stamparli su file txt
        public static void StampaFileTesto(List<Indirizzo> indirizzi, string path)
        {
            using StreamWriter stream = File.CreateText(path);
            foreach (var indirizzo in indirizzi)
                stream.WriteLine(indirizzo.ToString());
        }
    }
}

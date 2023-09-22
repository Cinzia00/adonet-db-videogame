using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    public class Videogame
    {
        public string Nome { get; private set; }
        public string Descrizione { get; private set; }
        public DateTime DataRilascio { get; private set; }
        public long SoftwareHouseID { get; private set; }


        public Videogame(string nome, string descrizione, DateTime dataRilascio, long softwareHouseID)
        {
            Nome = nome;
            Descrizione = descrizione;
            DataRilascio = dataRilascio;
            SoftwareHouseID = softwareHouseID;
        }

        public override string ToString()
        {
            return $"Il videogioco {this.Nome} è stato rilasciato in data: {this.DataRilascio}. Descrizione gioco: {this.Descrizione}";
        }
    }
}

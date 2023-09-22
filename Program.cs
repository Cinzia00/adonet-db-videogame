namespace adonet_db_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine(@"
1-Inserire un nuovo videogioco
2-Ricerca videogioco per id
3-Ricercare tutti i videogiochi per nome
4-Cancellare un videogioco
5-Chiudere il programma"
                );

                Console.WriteLine();
                Console.WriteLine("Scegli un opzione");

                int opzioneSelezionata = int.Parse(Console.ReadLine());

                switch (opzioneSelezionata)
                {
                    case 1:
                        Console.WriteLine("Inserisci nome: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Inserisci descrizione: ");
                        string descrizione = Console.ReadLine();

                        Console.WriteLine("Inserisci data di rilascio: ");
                        string dataRilascio = Console.ReadLine();
                        DateTime dataRilascio2 = DateTime.Parse(dataRilascio);

                        Console.WriteLine("Inserisci id: ");
                        long id = long.Parse(Console.ReadLine());


                        Videogame nuovoVideogame = new Videogame(name, descrizione, dataRilascio2, id);

                        bool inserito = VideogameManager.AggiungiVideogioco(nuovoVideogame);

                        if (inserito)
                        {
                            Console.WriteLine("Il videogioco è stato inserito con successo!");
                        }
                        else
                        {
                            Console.WriteLine("Videogioco non aggiunto");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Inserisci l'id del videogioco che vuoi cercare");
                        long idDaCercare = long.Parse(Console.ReadLine());

                        try
                        {
                            Videogame videogame = VideogameManager.RicercaGiocoPerId(idDaCercare);
                            Console.WriteLine(videogame.ToString());

                        }
                        catch
                        {
                            Console.WriteLine("ID non trovato");
                        }

                        break;

                    case 3:

                        Console.WriteLine("Nome del videogioco da ricercare: ");
                        string nomeVideogioco = Console.ReadLine();

                        List<Videogame> videogamesTrovati = VideogameManager.RicercaPerNome(nomeVideogioco);

                        Console.WriteLine("Videogiochi trovati: ");

                        foreach(var videogame in videogamesTrovati)
                        {
                            Console.WriteLine(videogame);
                        }

                        break;

                    case 4:
                        Console.WriteLine("Iserisci l'Id del gioco da cancellare");
                        long videogameDaCancellare = long.Parse(Console.ReadLine());
                        bool idVideogame = VideogameManager.CancellaVideogame(videogameDaCancellare);

                        if (idVideogame)
                        {
                            Console.WriteLine("Il videogioco è stato cancellato");
                        }else
                        {
                            Console.WriteLine("Videogioco non cancellato");
                        }
                        break;

                }

            }


        }
    }
}          




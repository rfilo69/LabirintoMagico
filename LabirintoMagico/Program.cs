System.Timers.Timer timer;
Random sceltaLabirintoRND = new Random();
Partita partita = new Partita();

bool check = false;
bool exit = true;
string rispostaUtente = "";
int sceltaLabirinto = 1;
char[,] labirinto;

timer = new System.Timers.Timer(15000); //Timer dei punti in millisecondi
timer.Elapsed += TimerScaduto; //Serve a collegare la funzione allo scadere del timer 

Console.Clear();
Console.WriteLine("\t\t\t \u001b[1mLEGGI ATTENTAMENTE\u001b[0m\n");
Console.WriteLine("Benvenuto nel labirinto magico!!");
Console.WriteLine("In questo gioco dovrai raggiungere il punto di arrivo in ogni labirinto \ncontrassegnato dalla lettera A. Inoltre dovrai obbligatoriamente raccogliere \ntutte le gemme presenti nel labirinto (ti basterà passarci sopra) che \nsaranno contrassegnate con il simbolo * \nBUON DIVERTIMENTO!!\n");
Console.WriteLine("Premi qualsiasi tasto per iniziare...");
Console.ReadKey();

do
{
    partita.ScegliLabirinto(sceltaLabirinto);
    timer.Start();
    do
    {
        Console.Clear();
        Console.WriteLine("Livello: " + sceltaLabirinto);
        Console.WriteLine("Punti partita: " + partita.Punti + "\n");
        Console.WriteLine("Gemme raccolte: [" + partita.ContatoreGemmeRaccolte + "/5] \n" );
        labirinto = partita.AggiornaPartita();

        for (int i = 0; i < labirinto.GetLength(0); i++)
        {
            for (int j = 0; j < labirinto.GetLength(1); j++)
            {
                if (labirinto[i,j] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(labirinto[i, j]);
                    Console.ResetColor();
                }else
                {
                    Console.Write(labirinto[i, j]);
                }
                
            }
            Console.WriteLine();
        }

        partita.MuoviGiocatore(Console.ReadKey());
        check = partita.VerificaVittoria();

    } while (!check);

    timer.Stop();
    Console.Clear();
    Console.WriteLine("HAI VINTO!!");
    Console.WriteLine("Hai totalizzato " + partita.Punti + "\n");
    

    if (sceltaLabirinto < 8)
    {
        do
        {
            Console.WriteLine("Vuoi continuare a giocare? [si/no] --> ");
            rispostaUtente = Console.ReadLine();
            rispostaUtente = rispostaUtente.ToLower();

            if (rispostaUtente == "si")
            {
                exit = false;
                if (sceltaLabirinto <= 8)
                {
                    sceltaLabirinto++;
                }else
                {
                    exit = true;
                }
            }else if (rispostaUtente == "no")
            {
                exit = true;   
            }else
            {
                Console.WriteLine("La risposta data non è valida. Riprovare!");
            }
        } while (rispostaUtente != "si" && rispostaUtente != "no");
    }else
    {
        exit = true;
    }
    

} while (!exit);

Console.WriteLine("Grazie per aver giocato, ora vai a studiare!");

void TimerScaduto(object sender, System.Timers.ElapsedEventArgs e)
{
    partita.Punti -= 10;

    if (partita.Punti <= 0)
    {
        partita.Punti = 0;
    }
}
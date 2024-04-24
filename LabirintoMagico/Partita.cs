class Partita
{
    Labirinto labirinto;
    Player player;
    public int Punti { get; set; } 
    public int ContatoreGemmeRaccolte { get; set; }

    public Partita()
    {
        labirinto = new Labirinto();
        player = new Player();
        Punti = 100;
        ContatoreGemmeRaccolte = 0;
    }
    public char[,] AggiornaPartita()
    {
        char[,] matriceAggiornata = new char[labirinto.GetLabirintoScelto().GetLength(0), labirinto.GetLabirintoScelto().GetLength(1)];

        for (int i = 0; i < labirinto.GetLabirintoScelto().GetLength(0); i++)
        {
            for (int j = 0; j < labirinto.GetLabirintoScelto().GetLength(1); j++)
            {
                if (i == player.GetPlayerPosY() && j == player.GetPlayerPosX())
                {
                    matriceAggiornata[i, j] = 'P';
                }
                else
                {
                    matriceAggiornata[i, j] = labirinto.GetLabirintoScelto()[i, j];
                }
            }
        }

        return matriceAggiornata;
    }
    public void MuoviGiocatore(ConsoleKeyInfo keyInfo)
    {
        if (keyInfo.Key == ConsoleKey.UpArrow && labirinto.GetLabirintoScelto()[player.GetPlayerPosY() - 1, player.GetPlayerPosX()] != '#' && labirinto.GetLabirintoScelto()[player.GetPlayerPosY() - 1, player.GetPlayerPosX()] != 'A')
        {
            player.SetPlayerPosY(player.GetPlayerPosY() - 1);
        }
        else if (keyInfo.Key == ConsoleKey.DownArrow && labirinto.GetLabirintoScelto()[player.GetPlayerPosY() + 1, player.GetPlayerPosX()] != '#' && labirinto.GetLabirintoScelto()[player.GetPlayerPosY() + 1, player.GetPlayerPosX()] != 'A')
        {
            player.SetPlayerPosY(player.GetPlayerPosY() + 1);
        }
        else if (keyInfo.Key == ConsoleKey.LeftArrow && labirinto.GetLabirintoScelto()[player.GetPlayerPosY(), player.GetPlayerPosX() - 1] != '#' && labirinto.GetLabirintoScelto()[player.GetPlayerPosY(), player.GetPlayerPosX() - 1] != 'A')
        {
            player.SetPlayerPosX(player.GetPlayerPosX() - 1);
        }
        else if (keyInfo.Key == ConsoleKey.RightArrow && labirinto.GetLabirintoScelto()[player.GetPlayerPosY(), player.GetPlayerPosX() + 1] != '#' && labirinto.GetLabirintoScelto()[player.GetPlayerPosY(), player.GetPlayerPosX() + 1] != 'A')
        {
            player.SetPlayerPosX(player.GetPlayerPosX() + 1);
        }

        RaccogliGemme(keyInfo);
    }
    public bool VerificaVittoria()
    {
        if (player.GetPlayerPosY() == labirinto.GetLabirintoScelto().GetLength(0) - 2 && player.GetPlayerPosX() == labirinto.GetLabirintoScelto().GetLength(1) - 2)
        {
            if (ContatoreGemmeRaccolte >= 5)
            {
                return true;
            }else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    void RaccogliGemme(ConsoleKeyInfo keyInfo)
    {
        if (labirinto.GetLabirintoScelto()[player.GetPlayerPosY(), player.GetPlayerPosX()] == '*')
        {
            labirinto.EliminaGemma(player.GetPlayerPosY(), player.GetPlayerPosX());
            ContatoreGemmeRaccolte += 1;
        }
    }

    public void ScegliLabirinto(int sceltaLabirinto)
    {
        player.SetPlayerPosX(1);
        player.SetPlayerPosY(1);
        ContatoreGemmeRaccolte = 0;
        Punti = 100;
        labirinto.ScegliLabirinto(sceltaLabirinto);
    }
}
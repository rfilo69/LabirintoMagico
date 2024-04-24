class Labirinto
{
    char[,] labirinto5 =
{
    { '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#' },
    { '#', ' ', ' ', ' ', 'A' },
    { '#', '#', '#', '#', '#' }
};
    char[,] labirinto8 =
{
    { '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', '#', '#', ' ', '#', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', '#', ' ', '#' },
    { '#', ' ', '#', ' ', ' ', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', 'A' },
    { '#', '#', '#', '#', '#', '#', '#', '#' }
};
    char[,] labirinto9 =
{
    { '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
    { '#', '#', '#', ' ', '#', ' ', '#', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', '#', '#', ' ', '#' },
    { '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#' },
    { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', 'A' },
    { '#', '#', '#', '#', '#', '#', '#', '#', '#' },
};

    char[,] labirinto10 =
{
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#' },
    { '#', '#', '#', '#', '#', ' ', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', '#', ' ', '#', ' ', '#' },
    { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', '#', '#', '#', '#' },
    { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', 'A' },
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
};
    char[,] labirinto12 =
{
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
    { '#', '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#' },
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#' },
    { '#', '#', ' ', ' ', ' ', '#', ' ', '#', '#', '#', ' ', '#' },
    { '#', '#', '#', ' ', '#', '#', ' ', '#', ' ', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', '#' },
    { '#', ' ', '#', '#', '#', '#', ' ', ' ', '#', ' ', ' ', 'A' },
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
};

    char[,] labirinto15 =
{
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', '#', '#', ' ', '#', '#', '#', '#', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', ' ', '#', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', '#', '#', '#', ' ', ' ', ' ', '#', '#', ' ', '#' },
    { '#', ' ', '#', ' ', ' ', ' ', '#', '#', ' ', '#', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#', '#', '#', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', '#', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#', '#', '#', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#' },
    { '#', '#', ' ', '#', '#', ' ', '#', ' ', '#', '#', '#', ' ', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#' },
    { '#', '#', ' ', '#', '#', '#', '#', ' ', '#', ' ', '#', '#', '#', ' ', '#' },
    { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', 'A' },
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
};
    char[,] labirinto18 =
{
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
    { '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#' },
    { '#', '#', '#', '#', '#', '#', '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', '#', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#' },
    { '#', '#', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', ' ', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#', '#', '#', '#', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
    { '#', '#', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', 'A' },
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
};

    char[,] labirinto20 =
{
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', '#', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#', ' ', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', '#', ' ', '#', ' ', ' ', ' ', '#' },
    { '#', '#', '#', ' ', '#', '#', '#', ' ', '#', '#', '#', ' ', '#', '#', ' ', '#', '#', '#', '#', '#' },
    { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
    { '#', '#', '#', ' ', '#', '#', '#', ' ', '#', '#', '#', ' ', '#', '#', ' ', '#', ' ', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', ' ', '#', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', '#' },
    { '#', '#', ' ', '#', '#', ' ', '#', '#', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', '#' },
    { '#', ' ', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#', '#', '#', ' ', '#' },
    { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', '#', '#', ' ', '#', '#', ' ', '#', '#', '#', ' ', 'A' },
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
};

    char[,] labirintoScelto;

    public void ScegliLabirinto(int sceltaLabirinto)
    {
        switch (sceltaLabirinto)
        {
            case 1:
                labirintoScelto = new char[5, 5];
                labirintoScelto = labirinto5;
                labirintoScelto = PosizionaGemme();
                break;
            case 2:
                labirintoScelto = new char[8, 8];
                labirintoScelto = labirinto8;
                labirintoScelto = PosizionaGemme();
                break;
            case 3:
                labirintoScelto = new char[9, 9];
                labirintoScelto = labirinto9;
                labirintoScelto = PosizionaGemme();
                break;
            case 4:
                labirintoScelto = new char[10, 10];
                labirintoScelto = labirinto10;
                labirintoScelto = PosizionaGemme();
                break;
            case 5:
                labirintoScelto = new char[12, 12];
                labirintoScelto = labirinto12;
                labirintoScelto = PosizionaGemme();
                break;
            case 6:
                labirintoScelto = new char[15, 15];
                labirintoScelto = labirinto15;
                labirintoScelto = PosizionaGemme();
                break;
            case 7:
                labirintoScelto = new char[18, 18];
                labirintoScelto = labirinto18;
                labirintoScelto = PosizionaGemme();
                break;
            case 8:
                labirintoScelto = new char[20, 20];
                labirintoScelto = labirinto20;
                labirintoScelto = PosizionaGemme();
                break;
            default:
                labirintoScelto = new char[10, 10];
                labirintoScelto = labirinto10;
                labirintoScelto = PosizionaGemme();
                break;
        }
    }
    public char[,] GetLabirintoScelto()
    {
        return labirintoScelto;
    }

    public void EliminaGemma(int x, int y)
    {
        labirintoScelto[x, y] = ' ';
    }

    char[,] PosizionaGemme()
    {
        Random posizioneGemma = new Random();
        int posizioneXGemma;
        int posizioneYGemma;
        char[,] labirintoConGemme;

        labirintoConGemme = labirintoScelto;

        for (int i = 0; i < 5; i++)
        {
            posizioneXGemma = posizioneGemma.Next(1, labirintoScelto.GetLength(1));
            posizioneYGemma = posizioneGemma.Next(1, labirintoScelto.GetLength(0));


            if (labirintoScelto[posizioneXGemma, posizioneYGemma] == ' ')
            {
                labirintoConGemme[posizioneXGemma, posizioneYGemma] = '*';

            }
            else
            {
                i--;
            }
        }
        return labirintoConGemme;
    }

}
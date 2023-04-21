

namespace JodoDaVelha;

public class Program
{
    static char[] matriz = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int posicao, jogador;

    static int Main(string[] args)
    {
        Console.WriteLine("## Jogo da Velha ##\n");
        Console.WriteLine(" - Jogador X vs Jogador O - \n");

        Reseta();

        Console.WriteLine("xXx Para começar o Jogo digite 1! xXx\n");
        int inicia = 1;
        inicia = int.Parse(Console.ReadLine());

        if (inicia == 1)
        {
            int decisao = 1;
            while (decisao == 1)
            {
                Jogo();
                Console.WriteLine("Para repetir o jogo digite 1!");
                Console.WriteLine("Para sair do jogo digite 2!");
                decisao = int.Parse(Console.ReadLine());

                if (decisao == 1)
                {
                    Reseta();
                }
                else
                {
                    Console.WriteLine("Jogo finalizado. Obrigada por jogar!");
                }
                Console.WriteLine("\n");
            }
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
        return 0;
    }
    static void Jogo()
    {
        int jogada;
        char checagem;
        jogador = 1;

        do
        {
            Corpo();
            if (jogador % 2 == 0)
            {
                jogador = 2;
            }
            else
            {
                jogador = 1;
            }
            Console.WriteLine("Jogador " + jogador + " escolha uma posição:");

            if (jogador == 1)
            {
                checagem = 'X';
            }
            else
            {
                checagem = 'O';
            }
            posicao = int.Parse(Console.ReadLine());
            VerificaPosicao(checagem);
            jogada = ChecarResultado();
            jogador++;
        }
        while (jogada == -1);
        if (jogada == 1)
        {
            Console.WriteLine("Parabéns! O joador " + --jogador + " Ganhou!!");
        }
        else
        {
            Console.WriteLine("Empatou!");
        }

    }
    static int ChecarResultado()
    {
        int returnValue = 0;
        if (matriz[1] == matriz[2] && matriz[2] == matriz[3])
        {
            returnValue = 1;
        }
        else if (matriz[1] == matriz[4] && matriz[4] == matriz[7])
        {
            returnValue = 1;
        }
        else if (matriz[1] == matriz[5] && matriz[5] == matriz[9])
        {
            returnValue = 1;
        }
        else if (matriz[2] == matriz[5] && matriz[5] == matriz[8])
        {
            returnValue = 1;
        }
        else if (matriz[3] == matriz[5] && matriz[5] == matriz[7])
        {
            returnValue = 1;
        }
        else if (matriz[3] == matriz[6] && matriz[6] == matriz[9])
        {
            returnValue = 1;
        }
        else if (matriz[4] == matriz[5] && matriz[5] == matriz[5])
        {
            returnValue = 1;
        }
        else if (matriz[7] == matriz[8] && matriz[8] == matriz[9])
        {
            returnValue = 1;
        }
        else if (matriz[1] != '1' && matriz[2] != '2' && matriz[3] != '3' && matriz[4] != '4' && matriz[5] != '5' && matriz[6] != '6' && matriz[7] != '7' && matriz[8] != '8' && matriz[9] != '9')
        {
            returnValue = 0;
        }
        else
        {
            returnValue = -1;
        }
        return returnValue;
    }
    static void Reseta()
    {
        matriz[1] = '1';
        matriz[2] = '2';
        matriz[3] = '3';
        matriz[4] = '4';
        matriz[5] = '5';
        matriz[6] = '6';
        matriz[7] = '7';
        matriz[8] = '8';
        matriz[9] = '9';
    }
    static void Corpo()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", matriz[1], matriz[2], matriz[3]);
        Console.WriteLine("_____|_____|______");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", matriz[4], matriz[5], matriz[6]);
        Console.WriteLine("_____|_____|______");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", matriz[7], matriz[8], matriz[9]);
        Console.WriteLine("     |     |      ");
    }
    static void VerificaPosicao(char checagem)
    {
        if (posicao == 1 && matriz[1] == '1')
        {
            matriz[1] = checagem;
        }
        else if (posicao == 2 && matriz[2] == '2')
        {
            matriz[2] = checagem;
        }
        else if (posicao == 3 && matriz[3] == '3')
        {
            matriz[3] = checagem;
        }
        else if (posicao == 4 && matriz[4] == '4')
        {
            matriz[4] = checagem;
        }
        else if (posicao == 5 && matriz[5] == '5')
        {
            matriz[5] = checagem;
        }
        else if (posicao == 6 && matriz[6] == '6')
        {
            matriz[6] = checagem;
        }
        else if (posicao == 7 && matriz[7] == '7')
        {
            matriz[7] = checagem;
        }
        else if (posicao == 8 && matriz[8] == '8')
        {
            matriz[8] = checagem;
        }
        else if (posicao == 9 && matriz[9] == '9')
        {
            matriz[9] = checagem;
        }
        else
        {
            Console.WriteLine("A posição é inválida, tente novamente:");
            jogador--;
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        void WriteTitle()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;

    // Texto a ser centralizado
    string title = "  ✊ PEDRA - PAPEL - TESOURA ✌️";
    
    // Determina o tamanho do quadro com base no comprimento do texto
    int largura = title.Length + 3; // 2 espaço extra de cada lado

    Console.WriteLine("╔" + new string('═', largura) + "╗");
    Console.WriteLine("║" + title + "   ║");
    Console.WriteLine("╚" + new string('═', largura) + "╝");

    Console.ResetColor();
}



        // Gera jogada do computador
        Random aleatorio = new Random();
        int seusPontos = 0;
        int meusPontos = 0;

        while (true)
        {
            WriteTitle();
            Console.WriteLine("🎉 Vamos jogar! 🎉");

            string suaJogada;
            while (true)
            {
                Console.WriteLine($"Escolha:\n (1) PEDRA ✊\n (2) PAPEL ✋\n (3) TESOURA ✌️");
                suaJogada = Console.ReadLine();
                if (suaJogada == "1" || suaJogada == "2" || suaJogada == "3")
                    break;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("🚫 ENTRADA INVÁLIDA! TENTE NOVAMENTE. 🚫");
                    Console.ResetColor();
            }

            int numeroAleatorio = aleatorio.Next(1, 4); // Gera um número entre 1 e 3
            string jogadaComputador = numeroAleatorio.ToString(); // Converte para string

            // Verifica o resultado
            if (suaJogada == jogadaComputador)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"😬 EMPATE! {suaJogada} empata com {jogadaComputador}.");
                Console.ResetColor();
            }
            else if ((suaJogada == "1" && jogadaComputador == "2") || 
                     (suaJogada == "2" && jogadaComputador == "3") || 
                     (suaJogada == "3" && jogadaComputador == "1"))
            {
                meusPontos++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"😶 VOCÊ PERDEU! {jogadaComputador} ganha de {suaJogada}.");
                Console.ResetColor();
            }
            else
            {
                seusPontos++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"🥳 VOCÊ GANHOU! {suaJogada} ganha de {jogadaComputador}. 🥳");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine($"Você {seusPontos} - {meusPontos} Computador");
            Console.WriteLine();

            // Pergunta se o jogador quer jogar novamente
            while (true)
            {
                Console.Write("Quer jogar novamente? (digite 1- sim ou 2- não): ");
                string resposta = Console.ReadLine();

                if (resposta == "1")
                    break; // Joga novamente
                else if (resposta == "2")
                {
                    WriteTitle();
                    Console.WriteLine("👋 Fim de jogo...");
                    return; // Sai do programa
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("🚫 ENTRADA INVÁLIDA! TENTE NOVAMENTE. 🚫");
                    Console.ResetColor();
                }
            }
        }
    }
}


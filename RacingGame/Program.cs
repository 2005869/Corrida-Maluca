using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RacingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resp = "S";

            

            while (resp == "S")
            {
                Console.Clear();
                Console.WriteLine("#$%@ - Corrida Maluca - #$%@\n\n");

                int tempoDeEspera = 150;
                String vencedor = "";
                int numeroVencedor = 0;

                int rodadas = 0;

                String jogadorHumano = "";
                Console.WriteLine("Digite o primeiro caractere do seu nome: ");
                jogadorHumano = Console.ReadLine();

                Console.WriteLine("Em qual corredor você aposta (1, 2 ou 3)?");
                int aposta = Convert.ToInt32(Console.ReadLine());

                Pista pista1 = new Pista(100, new Corredor(jogadorHumano));
                Pista pista2 = new Pista(100, new Corredor("G"));
                Pista pista3 = new Pista(100, new Corredor("H"));

                Boolean ganhou = false;


                while (ganhou == false)
                {
                    rodadas++;
                    Console.Clear();
                    Console.WriteLine("#$%@ - Corrida Maluca - #$%@\n\n");

                    pista1.ExibirPista();
                    pista2.ExibirPista();
                    pista3.ExibirPista();

                    Console.WriteLine("\n\nRodada " + rodadas);
                    Thread.Sleep(tempoDeEspera);
                    Console.Clear();

                    if (pista1.AtualizarCorrida() == true)
                    {
                        pista1.ExibirPista();
                        pista2.ExibirPista();
                        pista3.ExibirPista();
                        ganhou = true;
                        vencedor = pista1.Atleta.Nome;
                        numeroVencedor = 1;
                    }

                    if (pista2.AtualizarCorrida() == true)
                    {
                        pista1.ExibirPista();
                        pista2.ExibirPista();
                        pista3.ExibirPista();
                        ganhou = true;
                        vencedor = pista2.Atleta.Nome;
                        numeroVencedor = 2;
                    }

                    if (pista3.AtualizarCorrida() == true)
                    {
                        pista1.ExibirPista();
                        pista2.ExibirPista();
                        pista3.ExibirPista();
                        ganhou = true;
                        vencedor = pista3.Atleta.Nome;
                        numeroVencedor = 3;
                    }


                }
                Console.WriteLine("\n\n#$%@ - Corrida Maluca - #$%@\n\n");
                Console.WriteLine(vencedor + " venceu, PARABÉNS!!!");
                if (numeroVencedor == aposta) { Console.WriteLine("Parabéns você apostou no corredor vencedor!!!"); }
                else { Console.WriteLine("Você apostou no corredor errado. Tente outra vez..."); }
                Console.WriteLine("Fim de Jogo");
                Console.WriteLine("\n\nDeseja jogar novamente (S/N)? ");
                resp = Console.ReadLine().ToUpper();
                
            }
            Console.WriteLine("Até a próxima...");
            Console.ReadKey();
                      
        }

        
    }
}

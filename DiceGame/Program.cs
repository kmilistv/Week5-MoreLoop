﻿using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb on mängija viskas rohkem
            //mängija, kes viskab rohkem, ongi mängu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);

            //kasutaja vise
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                cpuScore = cpuScore + cpuRandom;
                userScore = userScore + userRandom;
            }
                Console.WriteLine($"Arvuti skoor oli {cpuScore}. Kasutaja skoor oli {userScore}.");


            if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
         
                
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
              
            }
            else
            {
                Console.WriteLine("Viik!");
            }
         
        }

        }
    }


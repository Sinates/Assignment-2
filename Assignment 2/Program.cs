using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int Secretnumber = 3;
            int Guess= 0;
            int GuessCount = 0;

            while (GuessCount < 3 )
               
            {
              
                Console.WriteLine("Guess a number");
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Secretnumber == Guess)
                {
                    Console.WriteLine("You got it");
                    return;


                }
                GuessCount++;
            }
            Console.WriteLine("You lost");


        }
        }
    }

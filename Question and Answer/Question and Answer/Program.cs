﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_and_Answer
{
    class Program
    {
        static void Main()
        {

            
            
































            
            
            
            
            // Bens Questions
            public static void sports()
            {



                string sports, like, fav, player;
                Console.WriteLine("Do you like Sport");
                sports = Console.ReadLine();
                if (sports == "No")
                {
                    Console.WriteLine("Sorry you are not wanted in this section");
                }
                else
                {
                    Console.WriteLine("What kind of Sport do you like?");
                    like = Console.ReadLine();
                    if (like == "Basketball")
                    {
                        Console.WriteLine("Better not be a Warriors fan");
                        Console.ReadLine();
                    }
                    Console.WriteLine($"Who's your favourite {like} Team?");
                    fav = Console.ReadLine();
                    Console.WriteLine($"Who's your favourtie player from {fav}");
                    player = Console.ReadLine();
                }
            }
            



            // Cody's Question
            Console.WriteLine("Do you like movies?");
            movies = Console.ReadLine();
            Console.WriteLine("What is your favourite movie of 2019?");
            movieFavourite = Console.ReadLine();
            Console.WriteLine("What is your favourite movie genre? (yes/no)");
            movieGenre = Console.ReadLine();
            if (movies = "no")
            {
                Console.WriteLine("Maybe the next section will be of more interest.");
            }
            else
            {
                Console.WriteLine("That's great!")
            }


            //Keegan's Questions
            string temp;
            Console.WriteLine("Do you watch Game of Thrones?");
            Console.ReadLine();
            Console.WriteLine("Nerd?");
            Console.ReadLine();
            Console.WriteLine("Are you a gamer?");
            Console.ReadLine();


            //Anthony's Questions
            string gender, age, number;
            int favourite;

            Console.WriteLine("Are you male or Female?");
            Console.ReadLine();
            Console.WriteLine("How old are you?");
            Console.ReadLine();
            Console.WriteLine("Pick your Favourite?");
            Console.WriteLine("1 - Sport");
            Console.WriteLine("2 - Movies");
            Console.WriteLine("3 - Music");
            number = Console.ReadLine();
            favourite = Convert.ToInt32(number);









        }
    }
}

using System;
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
            


<<<<<<< HEAD

<<<<<<< HEAD
=======
>>>>>>> e9c942b4572284eb297e395aefbbaeb3427efbbc
                // Cody's Question
                private static void movies()
=======
>>>>>>> 2ec84ff21cfedd21701e9d7de4fb2031d2dede95

                Console.WriteLine("Do you like movies?");
                movies = Console.ReadLine();
                if (movies = "no")
            {
                Console.WriteLine("Maybe the next section will be of more interest.");
            }
            else
            {
                    Console.WriteLine("What is your favourite movie of 2019?");
                    movieFavourite = Console.ReadLine();
                    if (movieFavourite == "Avengers") 
                    {
                        Console.WriteLine("Iron man dies.");
                        Console.ReadLine();
                    }
                    if (movieFavourite == "The Emoji Movie")
                    {
                        Console.WriteLine("Just get out.");
                        Console.ReadLine();
                    }


                    Console.WriteLine("What is your favourite movie genre?");
                    movieGenre = Console.ReadLine();
                    if (movieGenre == "comedy")
                    {
                        Console.WriteLine("So you like a good laugh, good choice.");
                        Console.ReadLine();
                    }
                    if (movieGenre == "anime")
                    {
                        Console.WriteLine("Ah, I see you're a man/woman of culture.");
                        Console.WriteLine();
                    }

                    Console.WriteLine("What is your least favourite movie?");
                    movieDislike = Console.ReadLine();
                    if (movieDislike == "The Emoji Movie")
                    {
                        Console.WriteLine("Pretty trash bro, don't watch it.");
                        Console.ReadLine();
                    }



                    Console.WriteLine($"So, your favourite movie of 2019 is {movieFavourite}.");
                    Console.WriteLine($"So, your favourite movie genre is {movieGenre}.");
                    Console.WriteLine($"So, your least favourite movie is {movieDislike}.");
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

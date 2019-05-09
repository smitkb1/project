using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_and_Answer
{
    class Program
    {
        public static void music()
        {
            string musicFan, genre, favArtist;
            Console.WriteLine("Are you a fan of music?");
            musicFan = Console.ReadLine();
            if (musicFan == "Yes")
            {
                Console.WriteLine("What's your favourite genre of music?");
                genre = Console.ReadLine();

                switch (genre)
                {
                    case "Pop":
                        Console.WriteLine($"You're into the popular stuff! Who's your favourite {genre} artist?");
                        favArtist = Console.ReadLine();
                        break;

                    case "Rock":
                        Console.WriteLine($"Who's your favourite {genre} artist?");
                        favArtist = Console.ReadLine();
                        break;

                    case "Hip-Hop":
                        Console.WriteLine($"Who's your favourite {genre} artist?");
                        favArtist = Console.ReadLine();
                        break;

                    case "Country":
                        Console.WriteLine($"Who's your favourite {genre} artist?");
                        favArtist = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine($"Interesting, I've never heard of {genre} before! Who's your favourite {genre} artist?");
                        favArtist = Console.ReadLine();
                        break;
                }

            }

        }


        static void Main()
        {

            //{ // Bens Questions
            //    string sports, like, fav;
            //    Console.WriteLine("Do you like Sport");
            //    sports = Console.ReadLine();

            //    Console.WriteLine("Who's your favourite Team?");
            //    fav = Console.ReadLine();
            //    if (sports = "No")
            //    {
            //        Console.WriteLine("Sorry you are not wanted in this section");
            //    }
            //    else (sports = "Yes")
            //Console.WriteLine("What kind of Sport do you like?");
            //    like = Console.ReadLine();

            
            




            //// Cody's Question
            //Console.WriteLine("Do you like movies?");
            //movies = Console.ReadLine();
            //Console.WriteLine("What is your favourite movie of 2019?");
            //movieFavourite = Console.ReadLine();
            //Console.WriteLine("What is your favourite movie genre? (yes/no)");
            //movieGenre = Console.ReadLine();
            //if (movies = "no")
            //{
            //    Console.WriteLine("Maybe the next section will be of more interest.");
            //}
            //else
            //{
            //    Console.WriteLine("That's great!")
            //}




            ////Anthony's Questions
            //string gender, age, number;
            //int favourite;

            //Console.WriteLine("Are you male or Female?");
            //Console.ReadLine();
            //Console.WriteLine("How old are you?");
            //Console.ReadLine();
            //Console.WriteLine("Pick your Favourite?");
            //Console.WriteLine("1 - Sport");
            //Console.WriteLine("2 - Movies");
            //Console.WriteLine("3 - Music");
            //number = Console.ReadLine();
            //favourite = Convert.ToInt32(number);

            //}
        }

    }
}

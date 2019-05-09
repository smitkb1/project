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
            //Keegans Question
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

            //Anthony's Questions
            string gender, age, number;
            int favourite;

            Console.WriteLine("Are you male or Female?");
            gender = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            Console.WriteLine("Pick your Favourite?");
            Console.WriteLine("1 - Sport");
            Console.WriteLine("2 - Movies");
            Console.WriteLine("3 - Music");
            number = Console.ReadLine();
            favourite = Convert.ToInt32(number);

            switch (favourite)
            {
                case '1':
                    sports();
                    break;

                case '2':
                    movies();
                    break;

                case '3':
                    music();
                    break;

                default:
                    Console.WriteLine("Pick again");
                    break;
            }
            if (favourite == 1)
            {
                Console.WriteLine("Pick your second Favourite");
            }
            Console.ReadLine();
        }

        //Codys Question
        public static void movies()
        {
            string movies, movieFavourite, movieGenre, movieDislike;
            Console.WriteLine("Do you like movies?");
            movies = Console.ReadLine();
            if (movies == "no")
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
        }




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
    }
}







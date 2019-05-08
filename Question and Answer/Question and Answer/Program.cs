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
            string sports, like, fav;
            Console.WriteLine("Do you like Sport");
            sports = Console.ReadLine();
            Console.WriteLine("What kind of Sport do you like?");
            like = Console.ReadLine();
            Console.WriteLine("Who's your favourite Team?");
            fav = Console.ReadLine();



            // Cody's Question
            Console.WriteLine("Do you want a spoiler?");
            Console.ReadLine();
            Console.WriteLine("Did you know Iron Man dies?");
            Console.ReadLine();
            Console.WriteLine("Or does he?");

            //Keegan's Questions
            string musicFan, genre;
            Console.WriteLine("Are you a fan of music?");
            musicFan = Console.ReadLine();
            if (musicFan == "Yes")
            {
                Console.WriteLine("What's your favourite genre of music?");
                genre = Console.ReadLine();
                switch (genre)
                {
                    case rock:

                }

            }
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("");
            Console.ReadLine();


            //Anthony's Questions
            Console.WriteLine("Kanye for president? Yes no?");
            Console.ReadLine();









        }

    }
}

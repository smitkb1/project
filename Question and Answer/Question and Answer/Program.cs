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

            { // Bens Questions
            string sports, like, fav;
            Console.WriteLine("Do you like Sport");
            sports = Console.ReadLine();
            
            Console.WriteLine("Who's your favourite Team?");
            fav = Console.ReadLine();
            if (sports = "No")
                {
                    Console.WriteLine("Sorry you are not wanted in this section");
                }
            else  (sports = "Yes")
            Console.WriteLine("What kind of Sport do you like?");
            like = Console.ReadLine();



            // Cody's Question
            Console.WriteLine("Do you want a spoiler?");
            Console.ReadLine();
            Console.WriteLine("Did you know Iron Man dies?");
            Console.ReadLine();
            Console.WriteLine("Or does he?");

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

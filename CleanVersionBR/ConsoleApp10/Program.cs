using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BEERROULETTE!!!! Please press enter to continue. Type 'end' whenever you want to exit the game.Insults are included. ");
            string userValue = Console.ReadLine();
            string message = "";

            while (userValue != "end")
            {
                Console.WriteLine("Choose any number from 1 - 10:");
                userValue = Console.ReadLine();

                if (userValue == "1")
                
                    message = "You're thinking too small. Shot Gun a beer you penis tamer. Once complete. Press ENTER.";
                    
              
                else if (userValue == "2")
                {
                    message = "Two is you. ";
                    message += "Choose someone that's funny when drunk. Once complete. Press ENTER. ";
                }
                else if (userValue == "3")
                {
                    message = "Three is free. ";
                    message += "Everyone who paid for beer get's rewarded by drinking. The one's that didn't pay, watch. FUCKEN FREELOADERS. Once complete. Press ENTER. ";
                }
                else if (userValue == "4")
                {
                    message = "Four is floor. ";
                    message += " Last person to point to the floor has drink. Once complete. Press ENTER. ";
                }
                else if (userValue == "5")
                {
                    message = "Five is guys. ";
                    message += "If there's nothing but guys (sausagefest) EVERYONE DRINKS TWICE!!! Disgusting. Once complete. Press ENTER. ";
                }
                else if (userValue == "6")
                {
                    message = "Six is tricks. ";
                    message += "Get a ball and cup. Everyone has to do a trick shot. (host decides if it's a trick) ";
                    message += "You miss, you drink. You make it, everyone drinks. Once complete. Press ENTER. ";
                }
                else if (userValue == "7")
                {
                    message = "Seven is Sober. ";
                    message += "You thought it was going to say heaven? You don't drink.";
                    message += "Over here assuming shit. Once complete. Press ENTER. ";
                }
                else if (userValue == "8")
                {
                    message = "Eight is traits. ";
                    message += "Go around complementing the person next to you, WHILE YELLING. ";
                    message += "The first person that laughs. DRINKS! Once complete. Press ENTER. ";
                }
                else if (userValue == "9")
                {
                    message = "Nine is mime. ";
                    message += "Everytime you open your dick holster. DRINK before you catch a dick!! Once complete. Press ENTER. ";
                }
                else if (userValue == "10")
                {
                    message = "Damn. Look at you. Going big. ";
                    message += "You choose two people and they become drinking buddies all game. One drinks then the other one drinks. Once complete. Press ENTER. ";
                }
                else

                    message = "Finish the beer you're drinking.  Once complete. Press ENTER. ";

                Console.WriteLine(message);
                Console.ReadLine();
            }
            message = "Thank you for playing. Come back and play again. Good Bye.";

            Console.WriteLine(message);
            Console.ReadLine();


        }
    }
}  

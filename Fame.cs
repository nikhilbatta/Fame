using System;
using System.Collections.Generic;

namespace Fame
{
    public class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("You're an up and coming actor exploring Hollywood. Whats your name?");
            string userName = Console.ReadLine();
            Celebrity UserCeleb = new Celebrity(userName);
            HollywoodAdventure(UserCeleb,"");

        }
            public static void HollywoodAdventure(Celebrity UserCeleb, string lastCeleb)
            {

                if(UserCeleb.Followers > 2000)
                {
                    Console.WriteLine("Congrats! You are so famous now! GAME OVER");
                    System.Environment.Exit(1);
                }
                else
                {
                string randomCelebrity = Situation.GenerateRandCeleb(lastCeleb);
                Situation.CelebrityFunctions[randomCelebrity](UserCeleb);
                }




            }

        
    }
}
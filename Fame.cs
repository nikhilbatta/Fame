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
                string randomCelebrity = Situation.GenerateRandCeleb(lastCeleb);
                Situation.CelebrityFunctions[randomCelebrity](UserCeleb);



        //     string[] Celebrities = {"Tom Cruise", "Dan Harmon", "Greg Graffins", "Angelina Jolie", "Andrew Peterson"}; 
        //     Random rand = new Random();
        //     int randomNum = rand.Next(0,Celebrities.Length-1);
        //     string newCeleb = Celebrities[randomNum];
            
        //     Console.WriteLine(newCeleb + " wants to invite you to a crazy roof party. Do you go? (y/n)");
        //     string userAnswer = Console.ReadLine();
        //     if(userAnswer == "y")
        //     {
        //         UserCeleb.QuestionAnsweredYes();
        //         Console.WriteLine("Congratulations! Your follower count increased! New follower count: " + UserCeleb.Followers);

                
        //     }
        //     else
        //     {
        //         UserCeleb.QuestionAnsweredNo();
        //         Console.WriteLine("Fuck" + UserCeleb.Name + "! Your follower count decreased! New follower count: " + UserCeleb.Followers);
        //     }
           
            
        //    HollywoodAdventure(UserCeleb);
            }
        
    }
}
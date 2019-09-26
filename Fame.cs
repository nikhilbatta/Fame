using System;
using System.Collections.Generic;

namespace Fame
{
    public class Program
    {
        public static void Main()
        {
            // Situation tomCruise = new Situation("Tom Cruise");
            // Console.WriteLine("Name: " + tomCruise.Name+ " \n Question 1: " + tomCruise.Questions[0]);+ "\n Question 2: " + tomCruise.Questions[1] + "\n Question 3: " +tomCruise.Questions[2]);
            Console.WriteLine("You're an up and coming actor exploring Hollywood. Whats your name?");
            string userName = Console.ReadLine();
            Celebrity UserCeleb = new Celebrity(userName);
            HollywoodAdventure(UserCeleb);

        }
            public static void HollywoodAdventure(Celebrity UserCeleb)
            {
                List<string> celebrityKeys = new List<string>(Situation.CelebrityFunctions.Keys);

                // Dictionary<string, Action> celebStories = new Dictionary<string, Action> (Situation.CelebrityFunctions);

                Random rand = new Random();
                int randomNum = rand.Next(0);
                Console.WriteLine(randomNum);
                string randomCelebrity = celebrityKeys[randomNum];
                Console.WriteLine(randomCelebrity);
                

                Situation.CelebrityFunctions[randomCelebrity]();



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
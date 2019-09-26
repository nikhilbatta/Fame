using System;
using System.Collections.Generic;
namespace Fame
{
    public class Situation
    {
        

        public static Dictionary<string,Action<Celebrity>> CelebrityFunctions = new Dictionary<string,Action<Celebrity>>{{"Tom Cruise", TomCruise}, {"Wiz Khalifa", WizKhalifa}};

        public static void TomCruise(Celebrity userCeleb)
        {
            Console.WriteLine("You see Tom Cruise in downtown LA at a donut coffee shop. Would you like to talk to him? Y/N");
            string answer1 = Console.ReadLine();
            if(answer1 == "y" || answer1 =="Y")
            {
               
                Console.WriteLine("Do you want to talk to him or insult him? T/I");
                string answer2 = Console.ReadLine();
                if(answer2 == "T" || answer2 == "t")
                {
                    Console.WriteLine("You introduce yourself like a normal person. He ends up talking to him for hours because it's been so long since someone has been so nice to him. Papparazzi take loads of pics and his die hard fans go after your followers! Lose 175 followers.");
                     userCeleb.QuestionAnsweredNo(175);

                }
                else if (answer2 == "I" || answer2 == "i")
                {
                    Console.WriteLine("You insult Tom Cruise with a string of language so foul we can't type it here. Someone nearby records the interaction on their phone. It goes viral. Gain 200 followers.");
                    userCeleb.QuestionAnsweredYes(200);
                }
                else
                {
                    Console.WriteLine("That's not a valid input. Try again.");
                    TomCruise(userCeleb);
                }

            }
            else if (answer1 == "N" || answer1 == "n")
            {
                Program.HollywoodAdventure(userCeleb);
            }       
            else
            {
                 Console.WriteLine("That's not a valid input. Try again.");
                TomCruise(userCeleb);
            }         
            
        }
        public static void WizKhalifa(Celebrity userCeleb)
        {
            Console.WriteLine("You see Wiz Khalifa at Six Flags. Would you like to talk to him? Y/N");
            string answer1 = Console.ReadLine();
            if(answer1 == "y" || answer1 =="Y")
            {
                Console.WriteLine("Do you want to ask him to smoke or insult him? S/I");
                string answer2 = Console.ReadLine();
                if(answer2 == "S" || answer2 == "s")
                {                   
                    Console.WriteLine("He's so impressed with your audacity he offers you a rip off his huge bong loaded with the finest sativa. One of his groupies posts pics of you guys hanging out. You gain 500 followers.");
                   userCeleb.QuestionAnsweredYes(500);

                }
                else if (answer2 == "I" || answer2 == "i")
                {
                    Console.WriteLine("I would smoke with you man but you don't seem chill enough for this weed. Also 6ix 9ine is way better than you. Because you're such a punk ass bitch you lose 500 followers. Also, everyone who is after 6ix 9ine is after you now. Good luck with that.");
                    userCeleb.QuestionAnsweredNo(500);
                }
                else
                {
                    Console.WriteLine("That's not a valid input. Try again.");
                    WizKhalifa(userCeleb);
                }

            }
            else if (answer1 == "N" || answer1 == "n")
            {
                Program.HollywoodAdventure(userCeleb);
            }
            else
            {
                 Console.WriteLine("That's not a valid input. Try again.");
                    WizKhalifa(userCeleb);
            }            
            
        }
        


    }
}
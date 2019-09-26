using System;
using System.Collections.Generic;
namespace Fame
{
    public class Situation
    {
        

        public static Dictionary<string,Action<Celebrity>> CelebrityFunctions = new Dictionary<string,Action<Celebrity>>{{"Tom Cruise", TomCruise}, {"Wiz Khalifa", WizKhalifa}, {"Elijah Wood", ElijahWood}, {"Jeff Probst", JeffProbst}, {"Jeff Goldblum", JeffGoldblum} };

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
        public static void ElijahWood(Celebrity userCeleb)
        {
            Console.WriteLine("You see Elijah Wood at the pub. Do you want to ask to join in a drink? Y/N");
            string answer1 = Console.ReadLine();
            if(answer1 == "y" || answer1 =="Y")
            {
                Console.WriteLine("He graciously offers to buy you a beer that sounds like it's imported from Germany. Will you accept? Y/N");
                string answer2 = Console.ReadLine();
                if(answer2 == "Y" || answer2 == "y")
                {                   
                    Console.WriteLine("You and Elijah get plastered and papparazzi take a picture of you both drunk singing in the street. You gain 150 followers.");
                   userCeleb.QuestionAnsweredYes(150);

                }
                else if (answer2 == "N" || answer2 == "n")
                {
                    Console.WriteLine("Elijah Wood is insulted and throws his drink in your face. You lose 100 followers.");
                    userCeleb.QuestionAnsweredNo(100);
                }
                else
                {
                    Console.WriteLine("That's not a valid input. Try again.");
                    ElijahWood(userCeleb);
                }

            }
            else if (answer1 == "N" || answer1 == "n")
            {
                Program.HollywoodAdventure(userCeleb);
            }
            else
            {
                 Console.WriteLine("That's not a valid input. Try again.");
                    ElijahWood(userCeleb);
            }            
            
        }
       public static void JeffProbst(Celebrity userCeleb)
        {
            Console.WriteLine("You met Jaff Probst at Hawaiian shave ice store. Do you talk to him?");
            string answer1 = Console.ReadLine();
            if(answer1 == "y" || answer1 =="Y")
            {
                Console.WriteLine("He offers to buy you one. Will you accept his offer? Y/N");
                string answer2 = Console.ReadLine();
                if(answer2 == "Y" || answer2 == "y")
                {                   
                    Console.WriteLine("You end up talking to him over some shave ice and tell him that one of your friends Andrew is a HUGE survivor fan. He loves hearing about his fantasy survivor league and ends uo asking Andrew to join the nrxt season of survivor.Andrew gets so famous after winning survivor, you are always in his insta post and gain 2000 followers.");
                   userCeleb.QuestionAnsweredYes(2000);

                }
                else if (answer2 == "N" || answer2 == "n")
                {
                    Console.WriteLine("He gets really sad and starts ranting about how terrible human being are. He gets really angry and drops his shave ice. Someone ends up recording and posted on twitter. #save jeff's shave ice starts trending and you losse 1000 followers.");
                    userCeleb.QuestionAnsweredNo(100);
                }
                else
                {
                    Console.WriteLine("That's not a valid input. Try again.");
                    JeffProbst(userCeleb);
                }

            }
            else if (answer1 == "N" || answer1 == "n")
            {
                Program.HollywoodAdventure(userCeleb);
            }
            else
            {
                 Console.WriteLine("That's not a valid input. Try again.");
                    JeffProbst(userCeleb);
            }            
            
        }

        public static void JeffGoldblum(Celebrity userCeleb)
        {
            Console.WriteLine("You see Jeff Goldblum at the grocery store filming his cooking show. Do you approach him at the cheese monger station and talk to him? Y/N");
            string answer1 = Console.ReadLine();
            if(answer1 == "y" || answer1 =="Y")
            {
                Console.WriteLine("Do you ask him what his favorite cheese is or do you ask about his latest film? C/F");
                string answer2 = Console.ReadLine();
                if(answer2 == "C" || answer2 == "c")
                {                   
                    Console.WriteLine("It turns out Jeff Goldblum is incredibly passionate about cheese. He knows SO MUCH about cheese he ends up talking to you about it for hours. It's so boring you pass out where you stand. It is humiliating. The cheese monger takes a pic of Jeff Goldblum trying to wake you up. It is adorable. It goes viral. You gain 300 followers.");
                   userCeleb.QuestionAnsweredYes(300);

                }
                else if (answer2 == "F" || answer2 == "f")
                {
                    Console.WriteLine("He smirks and says, 'How dare you'. You are so embarassed you offer to buy Jeff an expensive wheel of cheese. You lose $150.");
                    userCeleb.RemoveMoney(100);
                }
                else
                {
                    Console.WriteLine("That's not a valid input. Try again.");
                    JeffGoldblum(userCeleb);
                }

            }
            else if (answer1 == "N" || answer1 == "n")
            {
                Program.HollywoodAdventure(userCeleb);
            }
            else
            {
                 Console.WriteLine("That's not a valid input. Try again.");
                    JeffGoldblum(userCeleb);
            }            
            
        }


    }
}
using System;
using System.Collections.Generic;
namespace Fame
{
    public class Situation
    {
        

        public static Dictionary<string,Action<Celebrity>> CelebrityFunctions = new Dictionary<string,Action<Celebrity>>{{"Tom Cruise", TomCruise}};

        public static void TomCruise(Celebrity userCeleb)
        {
            Console.WriteLine("You see Tom Cruise in downtown LA at a donut coffee shop. Would you like to talk to him? Y/N");
            string answer1 = Console.ReadLine();
            if(answer1 == "y" || answer1 =="Y")
            {
                userCeleb.QuestionAnsweredYes();
            }
            else{
                

            }
        }
    }
}
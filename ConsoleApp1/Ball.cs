using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ball
    {

       public List<string> RESPONSES = new List<string> {
            "Get Lost",
            "You Wish",
            "In Your Dreams",
            "Meh, Ask again later",
            "Dunno",
            "Are you speaking English?",
            "Yasss Betch!",
            "You bet your sweet ass!",
            "I Guess",
            "Wait, Were you talking to me??"
            
            
        };
        
        public void StartGame()
        {
            while (true)
            {
                Console.WriteLine("Ask Magic8 Your Yes or No Question ");
                string userQuestion = Console.ReadLine();
                string response = GetResponse(0, RESPONSES.Count);
                Console.WriteLine(response);
            }
        }
        public string GetResponse(int min = 0, int max = 1)
        {  
            Random random = new Random();
            int index = random.Next(min, max);
            return RESPONSES[index];
        }


        

    }
    
}

using System;
using MarsRover.Models;
using MarsRover.Controllers;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        private static int _left;
        private static int _top;
        private static void AcceptInput()
        {
            ConsoleKeyInfo key = Console.ReadKey();
        
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    _left--;
                    break;
                case ConsoleKey.RightArrow:
                    _left++;
                    break;
                case ConsoleKey.UpArrow:
                    _top--;
                    break;
                case ConsoleKey.DownArrow:
                    _top++;
                    break;
        
            }
        }
        private static void DrawScreen()
        {
            Console.Clear();
            Console.SetCursorPosition(_left, _top);
            Console.Write('*');
        }
        static void Main(string[] args)
        {

            //Reads arguments from the stadard output.
            List<string> RawData = new List<string>();
            RawData.AddRange(args);
            
            Console.Clear();
            
            //validates User input
            UserInputs Transmission = new UserInputs();
            LaunchInput Data = Transmission.ValidateInput(RawData);

            if (Data != null){
                //Impliments the the valid input.
                Navigation connection = new Navigation();
                //if (Data.Count() < 6)
                Console.WriteLine(connection.NavigateRover(Data));
            }
        }
    }
}

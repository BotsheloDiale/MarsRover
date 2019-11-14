using System;
using MarsRover.Models;
using MarsRover.Controllers;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Note
            Console.WriteLine("Next45 Mars Rover\n");
            
            List<string> RawData = new List<string>();
            RawData.AddRange(args);
            
            UserInputs Transmission = new UserInputs();
            LaunchInput Data = Transmission.ValidateInput(RawData);

            //Connect and navigate Mars Rover
            Navigation connection = new Navigation();
            //if (Data.Count() < 6)
            Console.WriteLine(connection.NavigateRover(Data));
        }
    }
}

using System;
using MarsRover;
using MarsRover.Models;
using System.Collections.Generic;

namespace MarsRover.Controllers
{
    public class UserInputs {

        //Write to the Console Error messages, indicating the error in the User's input.
        private void ValidationFeedback(String InputType){
            Console.WriteLine("ERROR !! Invalid input.");
            if (InputType == "instructions"){
                Console.WriteLine("The Rover understands Only three commands:");
                Console.WriteLine("\t - M -> Move one space forward in the direction it is facing.");
                Console.WriteLine("\t - R -> rotate 90 degrees to the right. \n \t - L -> rotate 90 degrees to the left.");
            }
            else if (InputType == "direction"){
                Console.WriteLine("The Rover's Orientation (cardinal point) should be one of the following:");
                Console.WriteLine("\t - E -> East. \t - W -> West. \t - N -> North. \t - S -> South.\n");
            }
            else if (InputType == "coordinate"){
                Console.WriteLine("One or more of the Co-ordinates provided is/are invalid:");
                Console.WriteLine("\t - expected type -> integers only. e.g. 10 17 positive whole numbers \n");
            }
        }

        //Check if all the given numbers are positive numbers.
        private bool IsPositiveNumber(int x, int y, int limX, int limY){
            if (x > 0 && y > 0 && limX > 0 && limY > 0)
                return true;
            return false;
        }
        //Checks for user input validity.
        public LaunchInput ValidateInput(List<string> RawData){
            LaunchInput Data = new LaunchInput();
            try{
                if (RawData.Count == 6){
                    try{
                        if(IsPositiveNumber(Int32.Parse(RawData[0]), Int32.Parse(RawData[1]), Int32.Parse(RawData[2]), Int32.Parse(RawData[3]))){
                            Data.x = Int32.Parse(RawData[2]);
                            Data. y = Int32.Parse(RawData[3]);
                            Data.Limit_x = Int32.Parse(RawData[0]);
                            Data.Limit_y = Int32.Parse(RawData[1]);
                            Data.Direction = (RawData[4].ToUpper()).ToCharArray()[0];
                            Data.Instructions = RawData[5].ToUpper();
                        }
                        else 
                            throw new System.ArgumentException();
                    } catch{
                        ValidationFeedback("coordinate");
                        return null;
                    }
                    foreach(char move in Data.Instructions){
                        if (move != 'L' && move != 'M' && move != 'R'){
                            Console.WriteLine(move);
                            ValidationFeedback("instructions");
                            return null;
                        }
                    }
                    if (!("ESWN").Contains(Data.Direction)){
                        ValidationFeedback("direction");
                        return null;
                    }
                }
                return Data;
            }catch(Exception ){
                return null;
            }
        }
    }
}
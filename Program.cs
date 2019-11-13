using System;

namespace MarsRover
{
    class Program
    {
        //This method will return the new Rover direction
        // after applying a 90 degree (left/right) rotation.
        static char ChangeDirection(char Direction, char Rotaion){
            if (Rotaion == 'L'){
                switch (Direction) {
                    case 'E':
                        return 'N';
                    case 'N':
                        return 'W';
                    case 'W':
                        return 'S';
                    default :
                        return 'E';;
                }
            }
            else {
                switch (Direction) {
                    case 'E':
                        return 'S';
                    case 'S':
                        return 'W';
                    case 'W':
                        return 'N';
                    default :
                        return 'E';
                }
            }
        }
        static string NavigateRover(){
            //Map dimensions
            int xLimit = 10, yLimit = 10;

            //Starting position
            int x = 5, y = 5;
            char direction = 'E';

            //User Input
            string instruction = "MMRMMRMMRMM";
            
            try{
                foreach(char move in instruction.ToUpper()){
                    if (move == 'M'){
                        //If the rover is moving on the along the X-axis (Inner Array), Moves Left/Right
                        if (direction == 'E' || direction == 'W'){
                            switch (direction) {
                                case 'E':
                                    x++;
                                    break;
                                case 'W':
                                    x--;
                                    break;
                            }
                        }
                        //If the rover is moving on the along the Y-axis (Main Array), Moves Up/Down.
                        else if (direction == 'N' || direction == 'S'){
                            switch (direction) {
                                case 'S':
                                    y++;
                                    break;
                                case 'N':
                                    y--;
                                    break;
                            }
                        }
                        // Check if new position is still within bounds.
                        if (x >= xLimit || y >= yLimit){
                            Console.WriteLine("You have driven the Rover out of setalite range...");
                            return (" --- Mission Failed !! ---");
                        }
                    }
                    else{
                        direction = ChangeDirection(direction, move);
                    }
                }
                Console.WriteLine("********  Successful transmission...  ********");
                return ("\tCurrent Rover position  - "+ x + " " + y + " " + direction);
            } catch (Exception error) {
                Console.WriteLine(error);
                return ("Transmission to the Mars Rover has Failed!");
            }
        }
        static void Main(string[] args)
        {
            //Welcome Note
            Console.WriteLine("Next45 Mars Rover\n");

            foreach(string input in args){
                Console.WriteLine(input);
            }
            Console.WriteLine(NavigateRover());
        }
    }
}

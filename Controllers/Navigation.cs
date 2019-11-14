using System;
using MarsRover.Models;

namespace MarsRover.Controllers
{
    public class Navigation
    {
        
        //This method will return the new Rover direction
        // after applying a 90 degree (left/right) rotation.
        private char ChangeDirection(char Direction, char Rotaion){
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
        public string NavigateRover(LaunchInput Transmission){
            
            try{
                //Map dimensions
                int xLimit = Transmission.Limit_x , yLimit = Transmission.Limit_y;

                //Starting position
                int x = Transmission.x, y = Transmission.y;
                char direction = Transmission.Direction;

                //User Input
                string instruction = Transmission.Instructions;
            
                foreach(char move in instruction){
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
            } catch (Exception ) {
                Console.WriteLine("Input Error!\n \t Example input : 25 25 12 19 S MMRLMMMMML");
                return ("Transmission to the Mars Rover has Failed!\n\n");
            }
        }
    }
}
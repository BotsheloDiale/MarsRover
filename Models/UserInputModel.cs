using System;

namespace MarsRover.Models
{
    public class LaunchInput { 
        public int x {get; set;}
        public int y {get; set;}
        public int Limit_x {get; set;}
        public int Limit_y {get; set;}
        public char Direction {get; set;}
        public string Instructions {get; set;}
        //public string CardinalPoints {get; set;} = "EWSN";
    }

    
}
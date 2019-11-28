# MarsRover
Mars Rover is a simple console App that mimics a simple navigation system, with a list of given instruction it will
determine the destination.

# Program build
    .NetCore 2.1 Application (Easy to set-up).

# Using the Program
    From the project folder run the below mentioned command.
    **form running this command you should get an instruction of what sort of input is expected ($> dotnet run )
    $> dotnet run 8 10 1 2 E MMLMRMMRRMML 

    #Input
        - from the standard output, 6 arguments are expected.
        - The 1st two (8 and 10) represent the cartesian plain (Map) coordinates (x,y).
        - the following three, with 1 and 2 representing the rovers stating position on the map
            and E being the initial direction of movement.
        - the last group is the rover's movement commands, where M -> move forward, L -> Turn Left && R -> turn right.
    
    #EXAMPLES
        1)  1 1 1 1 E L                Result => 1 1 N
        2) 10 8 5 5 E ML               Result => 6 5 N
        3) 10 8 5 5 E MMMMMM           Result => --Out of bounds Error--
        4) 10 8 -5 5 E MMMMMM          Result => --Invalid Input Error--
        5)                             Result => --Invalid Input Error--
        6) 10 8  E MMMMMM              Result => --Invalid Input Error--
        7) 10 8 23 34 E MMMMMM 12 L    Result => --Invalid Input Error--
        8) 18 10 1 22 E RRRRRRRRRRRL   Result => 1 22 W
        9) 8 10 1 2 E MMLMRMMRRMML     Result => 3 1 S

    # Theres a simple test script included in the project folder.

# DESIGN DECISION
    ## Early stages 
                - the 1st commit the code was at its simplest and functional, 3 methods.
                - the challenge with that implemantation is that the code gets messy quickly as the project grows.
    
    ## Final Pattern
                - I used the "seperation of concerns" implementation to group code and make it easier to locate specific code.
                - and should the project grow bigger the code will still be easy to maintain.
                - just as MVC pattern the Controllers folder hosts all the logic separated by class
                - and the Model folder data presentation (object definitions).



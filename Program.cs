/* 
Treasure Map is a "choose your own adventure" style text game that provides a different outcome based on the user's choices at various checkpoints. 

The basic "proof of concept" skeleton was created on 8/28/24, containing three forks in logic and bare-bones display information.
*/

// Variables
bool gameRunning = true;
string checkpoint1;
string checkpoint2;
string checkpoint3;

// Variables for Data Collection
string? readResult;
bool validEntry = true;

do
{
    Console.WriteLine("Welcome to Checkpoint 1! Choose \"left\" or \"right\" to continue.");
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        checkpoint1 = readResult.ToLower();

        if (checkpoint1 != "left" && checkpoint1 != "right")
        {
            Console.WriteLine("That wasn't one of the choices.");
            validEntry = false;
            continue;
        }
        else
        {
            if (validEntry == true && checkpoint1 == "left")
            {
                Console.WriteLine("Dead End.");
                gameRunning = false;
                continue;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You made it past Checkpoint 1!");
                Console.WriteLine("");
                Console.WriteLine("Welcome to Checkpoint 2. Choose \"left\" or \"right\" to continue.");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    checkpoint2 = readResult.ToLower();

                    if (checkpoint2 != "left" && checkpoint2 != "right")
                    {
                        Console.WriteLine("That wasn't one of the choices.");
                        validEntry = false;
                        continue;
                    }
                    else
                    {
                        if (checkpoint2 == "left" && validEntry == true)
                        {
                            Console.WriteLine("Dead End.");
                            gameRunning = false;
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You made it past Checkpoint 2!");
                            Console.WriteLine("");
                            Console.WriteLine("Welcome to Checkpoint 3. Choose \"red\" to go through the red door, \"blue\" to go through the blue door, or \"yellow\" to go through the yellow door.");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                checkpoint3 = readResult.ToLower(); 
                                if (checkpoint3 != "red" && checkpoint3 != "blue" && checkpoint3 != "yellow")
                                {
                                    Console.WriteLine("That wasn't one of the choices.");
                                    validEntry = false;
                                }
                                else
                                {
                                    switch (checkpoint3)
                                    {
                                        case "red":
                                            Console.WriteLine("You lose.");
                                            gameRunning = false;
                                            break;
                                        case "blue":
                                            Console.WriteLine("You win!");
                                            gameRunning = false;
                                            break;
                                        case "yellow":
                                            Console.WriteLine("You lose.");
                                            gameRunning = false;
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
} while (gameRunning != false);

Console.WriteLine("Thanks for playing!");
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();
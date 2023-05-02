using static System.Console;


public class ProgramUI
{
    //Globally Scoped -> variables that can be used within any method
    private readonly EscapeRoomRepository _escRoomRepo = new EscapeRoomRepository();
    private EscapeRoom _escRoom;
    int rndEscRoom = 0;
    private bool IsRunning = true;
    private bool easyRiddleCorrect = false;
    private bool mediumRiddleCorrect = false;
    private bool hardRiddleCorrect = false;
    private bool playerIsAlive = true;

    public ProgramUI()
    {
        SeedData();
        _escRoom = _escRoomRepo.GetEscapeRoom();
    }

    private void SeedData()
    {
        _escRoomRepo.SeedEscapeRoomData();
    }

    public void Run()
    {
        // Set the random number to generate the riddles and room hints (randNumber = ID assigned to the riddles/hints)
        Random rnd = new Random();
        rndEscRoom = rnd.Next(3);
        System.Console.WriteLine($"Random number generated: {rndEscRoom}");
        RunApplication();
    }

    private void RunApplication()
    {


        while (IsRunning)
        {
            Clear();
            WriteLine("Are you able to escape each room by answering three riddles, Please make a selection:\n" +
            "1. Start Game\n" +
            "2. End Game\n");

            var userInput = ReadLine();

            switch (userInput)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    IsRunning = CloseGame();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    PressAnyKeyToContinue();
                    break;
            }
        }
    }
    private bool CloseGame()
    {
        // Clear(); //! Add back in for real game
        WriteLine("Thanks for Playing");
        PressAnyKeyToContinue();
        Clear();
        return false;
    }
    private void PressAnyKeyToContinue()
    {
        WriteLine("Press any Key to continue!");
        ReadKey();
    }
    private void StartGame()
    {
        Clear();
        // System.Console.WriteLine($"random riddle id: {rndRiddle}"); //?Prints out the randomnized number (for testing only, remove for final project) 
        //! This commented out section CAN BE MODIFIED
        //* Used to organize thoughts and train of thought on what is needed to be done
        while (playerIsAlive == true && IsRunning == true)
        {
            System.Console.WriteLine("You have been trapped inside a building with three rooms. You need to solve a riddle for each room in order to escape. Try not to die! \n" +
                                        "Press Any key to continue.");
            ReadKey();

            while (easyRiddleCorrect == false && IsRunning == true)
            {
                LoadEasyRoom();
            }


            //*Door opens and you move on to the next room

            while (mediumRiddleCorrect == false && IsRunning == true)
            {
                LoadMediumRoom();
            }

            //*Door opens and you move on to the final room

            while (hardRiddleCorrect == false && IsRunning == true)
            {
                LoadHardRoom();
            }

            AliveGameEnd();
            /*
                            ? Could use an if statement as well, don't have to use switch
                            switch (playerIsAlive)
                                case true:
                                    *AliveGameEnd();
                                    break;
                                default:
                                    *DeadGameEnd();
                                    break;

                        */
        }
        // System.Console.WriteLine("Start Game");
    }

    // private bool CheckAnswer(string guess)
    // {
    //     if (guess)
    //     {

    //     }
    //     else
    //     {

    //     }
    // }

    private void LoadEasyRoom()
    {
        Clear();
        // System.Console.WriteLine("LoadEasyRoom Method Triggered");
        //! Testing variables to see if they work: Currently only 'cuurentRoom' pulls something
        var currentRiddle = _escRoom.RiddlesInRoom;
        var currentHint = _escRoom.HintsInRoom[rndEscRoom];
        var ridAnswer = "paino";
    // var currentRoom = _escRoom.RoomID;
    // var indexesInList = _escRoom.RiddlesInRoom.Count;
    // var indexesInHList = _escRoom.HintsInRoom.Count;
    // System.Console.WriteLine(_escRoom.RiddlesInRoom[currentRoom]);
    // System.Console.WriteLine($"Pulling data from EscapRoomRepository:\n {currentRoom}\n {currentRiddle}\n {currentHint.Hints[0]}\n Riddle List Count: {indexesInList}\n Hint List Count: {indexesInHList}");
    // for (int i = 0; i < 3; i++)
    // {
    //     WriteLine(currentHint.Hints[i]);
    // }

    StartOfEasyLevel:
        Clear();

        WriteLine("Easy Room");
        WriteLine("What do you do first:\n"
                    + "1. (Triggers Hint 1)\n"
                    + "2. (Triggers Hint 2)\n"
                    + "3. (Triggers Hint 3)\n"
                    + "4. (Answer Riddle)\n"
                    + "5. Exit Game\n"
                    );

        var userInput = ReadLine();
        Clear();

        switch (userInput)
        {
            case "1":
                WriteLine(currentHint.Hints[0]);
                PressAnyKeyToContinue();
                goto StartOfEasyLevel;
            case "2":
                WriteLine(currentHint.Hints[1]);
                PressAnyKeyToContinue();
                goto StartOfEasyLevel;
            case "3":
                WriteLine(currentHint.Hints[2]);
                PressAnyKeyToContinue();
                goto StartOfEasyLevel;
            case "4":
                WriteLine("Your Answer: \n");
                var userAnswer = ReadLine();
                var guess = userAnswer.ToLower();
                if (guess == ridAnswer)
                {
                    WriteLine("Yay you got it correct!!!");
                    easyRiddleCorrect = true;
                    break;
                }
                else
                    WriteLine("Sorry that's wrong, Try Again!");

                // easyRiddleCorrect = CheckAnswer(userAnswer);
                PressAnyKeyToContinue();
                goto StartOfEasyLevel;
            case "5":
                IsRunning = CloseGame();
                break;
            default:
                WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                goto StartOfEasyLevel;
        }


        //IsRunning = CloseGame(); // Line for testing purposes only, delete in real game
        /*
            TODO: will need to call upon the riddle/room entities using the random number to pull the information needed
            * You enter the room and something speaks to you or you read the riddle by the door
            * You can choose to answer the riddle right away or you can take a look around the room //? Get hints
            * If you fail to answer the riddle in the correct ammount of time you die. //? Deaths are unique to the riddle/room you die in (maybe tbd if time allows it.)

            * Convert user input to all lowercase //! No forgiveness for mispelled answers, and for now added spaces
            * This will eliminate input errors of technically correct answers but are marked wrong due to caseSensitivity 
            if (userAnsInput == RiddleAnswer)
            {
                easyRiddleCorrect == true;
            }
            else 
            {
                lose a life/tries remaining
            }
        */
    }
    private void LoadMediumRoom()
    {
        Clear();
        // System.Console.WriteLine("LoadEasyRoom Method Triggered");
        //! Testing variables to see if they work: Currently only 'cuurentRoom' pulls something
        var currentRiddle = _escRoom.RiddlesInRoom;
        var currentHint = _escRoom.HintsInRoom[rndEscRoom + 3];
        var ridAnswer = "paino";

    StartOfMediumLevel:
        Clear();
        WriteLine("Medium Room");

        WriteLine("What do you do first:\n"
                    + "1. (Triggers Hint 1)\n"
                    + "2. (Triggers Hint 2)\n"
                    + "3. (Triggers Hint 3)\n"
                    + "4. (Answer Riddle)\n"
                    + "5. Exit Game\n"
                    );

        var userInput = ReadLine();
        Clear();

        switch (userInput)
        {
            case "1":
                WriteLine(currentHint.Hints[0]);
                PressAnyKeyToContinue();
                goto StartOfMediumLevel;
            case "2":
                WriteLine(currentHint.Hints[1]);
                PressAnyKeyToContinue();
                goto StartOfMediumLevel;
            case "3":
                WriteLine(currentHint.Hints[2]);
                PressAnyKeyToContinue();
                goto StartOfMediumLevel;
            case "4":
                WriteLine("Your Answer: \n");
                var userAnswer = ReadLine();
                var guess = userAnswer.ToLower();
                if (guess == ridAnswer)
                {
                    WriteLine("Medium: Yay you got it correct!!!");
                    mediumRiddleCorrect = true;
                    break;
                }
                else
                    WriteLine("Sorry that's wrong, Try Again!");

                // easyRiddleCorrect = CheckAnswer(userAnswer);
                PressAnyKeyToContinue();
                goto StartOfMediumLevel;
            case "5":
                IsRunning = CloseGame();
                break;
            default:
                WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                goto StartOfMediumLevel;
        }


        // Same process as the LoadEasyRoom()
    }
    private void LoadHardRoom()
    {
        Clear();
        // System.Console.WriteLine("LoadEasyRoom Method Triggered");
        //! Testing variables to see if they work: Currently only 'cuurentRoom' pulls something
        var currentRiddle = _escRoom.RiddlesInRoom;
        var currentHint = _escRoom.HintsInRoom[rndEscRoom + 6];
        var ridAnswer = "paino";

    StartOfHardLevel:
        Clear();
        WriteLine("Hard Room");

        WriteLine("What do you do first:\n"
                    + "1. (Triggers Hint 1)\n"
                    + "2. (Triggers Hint 2)\n"
                    + "3. (Triggers Hint 3)\n"
                    + "4. (Answer Riddle)\n"
                    + "5. Exit Game\n"
                    );

        var userInput = ReadLine();
        Clear();

        switch (userInput)
        {
            case "1":
                WriteLine(currentHint.Hints[0 + 6]);
                PressAnyKeyToContinue();
                goto StartOfHardLevel;
            case "2":
                WriteLine(currentHint.Hints[1 + 6]);
                PressAnyKeyToContinue();
                goto StartOfHardLevel;
            case "3":
                WriteLine(currentHint.Hints[2 + 6]);
                PressAnyKeyToContinue();
                goto StartOfHardLevel;
            case "4":
                WriteLine("Your Answer: \n");
                var userAnswer = ReadLine();
                var guess = userAnswer.ToLower();
                if (guess == ridAnswer)
                {
                    WriteLine("Hard: Yay you got it correct!!!");
                    hardRiddleCorrect = true;
                    break;
                }
                else
                    WriteLine("Sorry that's wrong, Try Again!");

                // easyRiddleCorrect = CheckAnswer(userAnswer);
                PressAnyKeyToContinue();
                goto StartOfHardLevel;
            case "5":
                IsRunning = CloseGame();
                break;
            default:
                WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                goto StartOfHardLevel;
        }
        // Same process as the LoadEasyRoom()
    }
    private void AliveGameEnd()
    {
        Clear();
        WriteLine("YAY you escaped!!!");
        // YAY you escaped!
        IsRunning = CloseGame();
    }
    private void DeadGameEnd()
    {
        Clear();
        // BOO you died!
    }






}
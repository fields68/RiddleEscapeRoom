using static System.Console;


public class ProgramUI
{
    //Globally Scoped -> variables that can be used within any method
    private readonly EscapeRoomRepository _escRoomRepo = new EscapeRoomRepository();
    private EscapeRoom _escRoom;
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
        RunApplication();
    }

    private void RunApplication()
    {


        while (IsRunning)
        {
            // Clear();
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

            while (easyRiddleCorrect == false)
            {
                LoadEasyRoom();
            }
            /*

                * Door opens and you move on to the next room 

                while (mediumRiddleCorrect == false)
                {
                    *LoadMediumRoom();
                }

                * Door opens and you move on to the final room 

                while (hardRiddleCorrect == false)
                {
                    *LoadHardRoom();
                }

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

    private void LoadEasyRoom()
    {
        Clear();
        System.Console.WriteLine("LoadEasyRoom Method Triggered");
        //! Testing variables to see if they work: Currently only 'cuurentRoom' pulls something
        var currentRoom = _escRoom.RoomID;
        var currentRiddle = _escRoom.RiddlesInRoom;
        var indexesInList = _escRoom.RiddlesInRoom.Count;
        var indexesInHList = _escRoom.HintsInRoom.Count;
        var currentHint = _escRoom.HintsInRoom;
        // System.Console.WriteLine(_escRoom.RiddlesInRoom[currentRoom]);
        System.Console.WriteLine($"Pulling data from EscapRoomRepository:\n {currentRoom}\n {currentRiddle}\n {currentHint}\n Riddle List Count: {indexesInList}\n Hint List Count: {indexesInHList}");
        easyRiddleCorrect = true;
        IsRunning = CloseGame(); // Line for testing purposes only, delete in real game
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
        // Same process as the LoadEasyRoom()
    }
    private void LoadHardRoom()
    {
        Clear();
        // Same process as the LoadEasyRoom()
    }
    private void AliveGameEnd()
    {
        Clear();
        // YAY you escaped!
    }
    private void DeadGameEnd()
    {
        Clear();
        // BOO you died!
    }






}
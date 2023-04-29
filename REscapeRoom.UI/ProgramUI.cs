using static System.Console;


public class ProgramUI
{
    private bool IsRunning = true;

    // public ProgramUI()
    // {
    //     SeedData();
    //     _room = _rEscapeRepo.GetEscapeRoom();
    // }

    public void Run()
    {
        // Set the random number to generate the riddles and room hints (randNumber = ID assigned to the riddles/hints)
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
        /*
        ! This commented out section CAN BE MODIFIED
        * Used to organize thoughts and train of thought on what is needed to be done
        while (playerIsAlive == true && IsRunning == true)
        {
            System.Console.WriteLine("You have been trapped inside a building with three rooms. You need to solve a riddle for each room in order to escape. Try not to die! \n" +
                                        "Press Any key to continue.");
            ReadKey();

            while (easyRiddleCorrect == false)
            {
                *LoadEasyRoom();
            }

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

        }
        */
        System.Console.WriteLine("Start Game");
        IsRunning = CloseGame(); // Line for testing purposes only, delete in real game
    }

    private void LoadEasyRoom()
    {
        /*
            TODO: will need to call upon the riddle/room entities using the random number to pull the information needed
            * You enter the room and something speaks to you or you read the riddle by the door
            * You can choose to answer the riddle right away or you can take a look around the room //? Get hints
            * If you fail to answer the riddle in the correct ammount of time you die. //? Deaths are unique to the riddle/room you die in

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
        // Same process as the LoadEasyRoom()
    }
    private void LoadHardRoom()
    {
        // Same process as the LoadEasyRoom()
    }
    private void AliveGameEnd()
    {
        // YAY you escaped!
    }
    private void DeadGameEnd()
    {
        // BOO you died!
    }






}
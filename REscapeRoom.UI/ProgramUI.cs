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
    private bool userExit = true;

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

        while (IsRunning == true)
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
                userExit = false;
            }

            if (userExit == false)
            {
                AliveGameEnd();
                IsRunning = CloseGame();
            }
            else
            {
                IsRunning = CloseGame();
            }
        }
    }


    private void LoadEasyRoom()
    {
        Clear();

        var currentRiddle = _escRoom.RiddlesInRoom[0];
        var currentHint = _escRoom.HintsInRoom[rndEscRoom];
        var riddleQuestions = currentRiddle.Questions[rndEscRoom];
        var ridAnswer = riddleQuestions.Answer;


        Clear();

        WriteLine("Easy Room Riddle:\n"
                    + $"{riddleQuestions.Title}");
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
                break;
            case "2":
                WriteLine(currentHint.Hints[1]);
                PressAnyKeyToContinue();
                break;
            case "3":
                WriteLine(currentHint.Hints[2]);
                PressAnyKeyToContinue();
                break;
            case "4":
                WriteLine("Your Answer: \n");
                var userAnswer = ReadLine();
                var guess = userAnswer.ToLower();
                if (guess == ridAnswer.ToLower())
                {
                    WriteLine("Yay you got it correct!!!");
                    PressAnyKeyToContinue();
                    easyRiddleCorrect = true;
                    break;
                }
                else
                    WriteLine("Sorry that's wrong, Try Again!");

                PressAnyKeyToContinue();
                break;
            case "5":
                IsRunning = CloseGame();
                break;
            default:
                WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                break;
        }

    }
    private void LoadMediumRoom()
    {
        Clear();

        var currentRiddle = _escRoom.RiddlesInRoom[1];
        var currentHint = _escRoom.HintsInRoom[rndEscRoom + 3];
        var riddleQuestions = currentRiddle.Questions[rndEscRoom];
        var ridAnswer = riddleQuestions.Answer;


        Clear();
        WriteLine(riddleQuestions.Title);

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
                break;
            case "2":
                WriteLine(currentHint.Hints[1]);
                PressAnyKeyToContinue();
                break;
            case "3":
                WriteLine(currentHint.Hints[2]);
                PressAnyKeyToContinue();
                break;
            case "4":
                WriteLine("Your Answer: \n");
                var userAnswer = ReadLine();
                var guess = userAnswer.ToLower();
                if (guess == ridAnswer.ToLower())
                {
                    WriteLine("Yay you got it correct!!!");
                    PressAnyKeyToContinue();
                    mediumRiddleCorrect = true;
                    break;
                }
                else
                    WriteLine("Sorry that's wrong, Try Again!");

                PressAnyKeyToContinue();
                break;
            case "5":
                IsRunning = CloseGame();
                break;
            default:
                WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                break;
        }

    }
    private void LoadHardRoom()
    {
        Clear();

        var currentRiddle = _escRoom.RiddlesInRoom[2];
        var currentHint = _escRoom.HintsInRoom[rndEscRoom + 6];
        var riddleQuestions = currentRiddle.Questions[rndEscRoom];
        var ridAnswer = riddleQuestions.Answer;


        Clear();
        WriteLine(riddleQuestions.Title);

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
                break;
            case "2":
                WriteLine(currentHint.Hints[1]);
                PressAnyKeyToContinue();
                break;
            case "3":
                WriteLine(currentHint.Hints[2]);
                PressAnyKeyToContinue();
                break;
            case "4":
                WriteLine("Your Answer: \n");
                var userAnswer = ReadLine();
                var guess = userAnswer.ToLower();
                if (guess == ridAnswer.ToLower())
                {
                    WriteLine("Yay you got it correct!!!");
                    PressAnyKeyToContinue();
                    hardRiddleCorrect = true;

                    break;
                }
                else
                    WriteLine("Sorry that's wrong, Try Again!");

                PressAnyKeyToContinue();
                break;
            case "5":
                IsRunning = CloseGame();
                break;
            default:
                WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                break;
        }
    }
    private void AliveGameEnd()
    {
        Clear();
        WriteLine("YAY you escaped!!!");
        // YAY you escaped!
    }
    private void DeadGameEnd()
    {
        Clear();
        // BOO you died!
    }






}
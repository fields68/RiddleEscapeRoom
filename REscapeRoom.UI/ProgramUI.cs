using static System.Console;


public class ProgramUI
{
    private bool IsRunning = true;

    // public ProgramUI()
    // {
    //     SeedData();
    //     _room = _hHouseRepo.GetEscapeRoom();
    // }

    public void Run()
    {
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
        System.Console.WriteLine("Start Game");
        IsRunning = CloseGame(); // Line for testing purposes only, delete in real game
    }

    private void LoadEasyRoom()
    { }
    private void LoadMediumRoom()
    { }
    private void LoadHardRoom()
    { }






}
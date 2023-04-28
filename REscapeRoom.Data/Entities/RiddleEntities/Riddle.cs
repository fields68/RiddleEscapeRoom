
public abstract class Riddle
{
    public int ID { get; set; }

    public List<string> RiddleQuestion { get; set; } = new List<string>();

    public string RiddleAnswer { get; set; }

    public bool IsCorrectAnswer
    {
        get
        {
            return (playerInput == RiddleAnswer) ? true : false;
        }
    }

    public void DecreaseHealth(int incorrectAnswer = 1)
    {
        HealthPoints -= incorrectAnswer;
    }

}

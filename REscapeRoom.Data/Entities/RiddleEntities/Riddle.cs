
public class Riddle
{
    public int ID { get; set; }

    // we can assign each riddle with a difficulty
    public RiddleDifficulty RiddleDifficulty { get; set; }

    public List<Question> Questions { get; set; } = new List<Question>();
}

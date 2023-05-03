// Clarissa's Brain is still working on making this piece of the puzzle fit.
public class RoomHint
{
    // Unique Identifier
    public RiddleDifficulty Difficulty { get; set; }
    public int HintID { get; set; }

    public List<Hint> Hints { get; set; } = new List<Hint>();


    public override string ToString()
    {
        return "HintID " + HintID + "\nDifficulty: " + Difficulty + "\n Sentence " + Hints[0];
    }


}

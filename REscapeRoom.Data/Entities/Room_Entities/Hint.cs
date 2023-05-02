
public class Hint
{

    public int HintID { get; set; }

    public string sentenceH { get; set; } = string.Empty;

    // Returns the hint sentence
    public override string ToString()
    {
        // return "HintID " + HintID + " Hint: " + sentenceH;
        return sentenceH;
    }

}

public class Hint
{

    public int HintID { get; set; }

    public string sentenceH { get; set; } = string.Empty;

    public override string ToString()
    {
        return "HintID " + HintID + " Hint: " + sentenceH;
    }

}
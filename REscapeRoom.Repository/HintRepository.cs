// Ther creation of the hints list
public class HintRepository
{
    public HintRepository()
    {
        SeedEasyRoom();
        SeedMediumRoom();
        SeedHardRoom();
    }
    List<RoomHint> _hintDB = new List<RoomHint>();
    public void SeedEasyRoom()
    {
        var eHint1_1 = new RoomHint
        {
            Difficulty = (int)RiddleDifficulty.Easy,
            HintID = 1,
            Hint = "Easy Fire hint 1"
        };
        var eHint1_2 = new RoomHint
        {
            Difficulty = (int)RiddleDifficulty.Easy,
            HintID = 2,
            Hint = "Easy Fire hint 2"
        };
        var eHint1_3 = new RoomHint
        {
            Difficulty = (int)RiddleDifficulty.Easy,
            HintID = 3,
            Hint = "Easy Fire hint 3"
        };
        _hintDB.Add(eHint1_1);
        _hintDB.Add(eHint1_2);
        _hintDB.Add(eHint1_3);
    }

    public void SeedMediumRoom()
    { }
    public void SeedHardRoom()
    { }
}

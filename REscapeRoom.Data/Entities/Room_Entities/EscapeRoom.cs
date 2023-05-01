public class EscapeRoom
{
    // What each room needs to have

    // ID for easyRoom, mediumRoom, HardRoom
    public int RoomID { get; set; }

    // Riddle for the rooms
    public List<Riddle> RiddlesInRoom { get; set; } = new List<Riddle>();

    // The room hints
    public List<RoomHint> HintsInRoom { get; set; } = new List<RoomHint>();

}
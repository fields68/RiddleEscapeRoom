public class EscapeRoomRepository
{
    private RiddleRepository _escRoomRiddleRepo = new RiddleRepository();
    private HintRepository _escRoomHintRepo = new HintRepository();
    private readonly List<EscapeRoom> _escRoomDb = new List<EscapeRoom>();
    private int _count = 0;

    public bool AddEscapeRoom(EscapeRoom escRoom)
    {
        if (escRoom is null)
        {
            return false;
        }
        else
        {
            _count++;
            escRoom.RoomID = _count;
            _escRoomDb.Add(escRoom);
            return true;
        }
    }

    public EscapeRoom GetEscapeRoom()
    {
        // L.I.N.Q

        return _escRoomDb.FirstOrDefault()!;
        // return _escRoomDb.Find(h => h.ID == id)!;
        // return _escRoomDb.First();
        // return _escRoomDb.Single();
        // return _escRoomDb.SingleOrDefault(x=>x.ID ==id);
        // return _escRoomDb.Last();
    }
    public void SeedEscapeRoomData()
    {
        var escapeRoom = new EscapeRoom();
        escapeRoom.HintsInRoom = _escRoomHintRepo.GetHints();
        AddEscapeRoom(escapeRoom);
    }
}

/*
    ! what i need to pull up all information regarding rooms
    * Easy Riddle
    * Easy Riddle Hints 
    * Medium Riddle
    * Medium Riddle Hints 
    * Hard Riddle
    * Hard Riddle Hints 
*/
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
        return _escRoomDb.FirstOrDefault()!;
    }
    public void SeedEscapeRoomData()
    {
        var escapeRoom = new EscapeRoom();
        escapeRoom.HintsInRoom = _escRoomHintRepo.GetHints();
        escapeRoom.RiddlesInRoom = _escRoomRiddleRepo.GetRiddles();
        AddEscapeRoom(escapeRoom);
    }
}
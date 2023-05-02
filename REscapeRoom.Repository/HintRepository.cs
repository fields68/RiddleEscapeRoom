// Ther creation of the hints list
public class HintRepository
{
    public HintRepository()
    {
        SeedEasyRoom();
        SeedMediumRoom();
        SeedHardRoom();
    }
    private List<RoomHint> _rHintDB = new List<RoomHint>();
    private List<Hint> _hintDB = new List<Hint>();

    private int _count = 0;

    public List<RoomHint> GetHints()
    {
        return _rHintDB;
    }

    public bool AddRoomHints(RoomHint roomhint)
    {
        if (roomhint is null)
            return false;
        else
        {
            _count++;
            roomhint.HintID = _count;
            // _hintDB.Add(roomhint);
            _rHintDB.Add(roomhint);
            return true;
        }
    }

    public void addHint()
    {
        // _hintDB.Add(new Hint() { HintID = 1, sentenceH = "Easy Fire hint 1" });
        // _hintDB.Add(new Hint() { HintID = 2, sentenceH = "Easy Fire hint 2" });
        // _hintDB.Add(new Hint() { HintID = 3, sentenceH = "Easy Fire hint 3" });
        foreach (Hint hint in _hintDB)
        {
            System.Console.WriteLine(hint);
        }
    }

    public void SeedEasyRoom()
    {
        System.Console.WriteLine("SeedEasyRoomTriggered");
        var eHint1 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Easy,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Easy Fire hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Easy Fire hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Easy Fire hint 3"
                }
            }
        };

        var eHint2 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Easy,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Easy M hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Easy M hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Easy M hint 3"
                }
            }
        };
        var eHint3 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Easy,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Easy paino hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Easy paino hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Easy paino hint 3"
                }
            }
        };
        AddRoomHints(eHint1);
        AddRoomHints(eHint2);
        AddRoomHints(eHint3);

        // foreach (RoomHint roomhint in _rHintDB)
        // {
        //     System.Console.WriteLine(roomhint);
        // }
    }

    public void SeedMediumRoom()
    {
        System.Console.WriteLine("SeedMediumRoomTriggered");
        var mHint1 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Medium,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Medium r hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Medium r hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Medium r hint 3"
                }
            }
        };

        var mHint2 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Medium,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Medium memories hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Medium memories hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Medium memories hint 3"
                }
            }
        };
        var mHint3 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Medium,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Medium unknown hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Medium unknown hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Medium unknown hint 3"
                }
            }
        };
        AddRoomHints(mHint1);
        AddRoomHints(mHint2);
        AddRoomHints(mHint3);
    }
    public void SeedHardRoom()
    {
        System.Console.WriteLine("SeedHardRoomTriggered");
        var hHint1 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Hard,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Hard eye hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Hard eye hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Hard eye hint 3"
                }
            }
        };

        var hHint2 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Hard,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Hard heroine hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Hard heroine hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Hard heroine hint 3"
                }
            }
        };
        var hHint3 = new RoomHint
        {
            Difficulty = RiddleDifficulty.Hard,
            Hints = new List<Hint>
            {
                new Hint
                {
                    HintID = 1,
                    sentenceH = "Hard unknown hint 1"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "Hard unknown hint 2"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Hard unknown hint 3"
                }
            }
        };
        AddRoomHints(hHint1);
        AddRoomHints(hHint2);
        AddRoomHints(hHint3);
    }
}

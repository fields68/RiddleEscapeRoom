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
            _rHintDB.Add(roomhint);
            return true;
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
                    sentenceH = "You start to sweat as temperature rises."
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "It can be different colors depending on an element."
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Typically you want to have control over this."
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
                    sentenceH = "It has 4 ticks."
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "It has a V shape in the middle."
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "You may use this letter to describe a good meal."
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
                    sentenceH = "The keys are flat."
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "All the keys are black and white."
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "You cannot hold it."
                }
            }
        };
        AddRoomHints(eHint1);
        AddRoomHints(eHint2);
        AddRoomHints(eHint3);
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
                    sentenceH = "It looks like an arch"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "It's an alphabet letter"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Spell March and April"
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
                    sentenceH = "Only you have it but you can share it."
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "It can bring tears or smiles."
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "It can get you in trouble sometimes."
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
                    sentenceH = "It always start at 9am."
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "It will never wait for you."
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "It has numbers on it."
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
                    sentenceH = "It's a great sight to behold"
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "It's stacked between two lids"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "One of your 5 senses"
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
                    sentenceH = "It comes handy in darkness."
                },

                new Hint
                {
                    HintID = 2,
                    sentenceH = "It has WICK inside"
                },
                new Hint
                {
                    HintID = 3,
                    sentenceH = "Sometimes an air freshener."
                }
            }
        };
        AddRoomHints(hHint1);
        AddRoomHints(hHint2);
        AddRoomHints(hHint3);
    }
}

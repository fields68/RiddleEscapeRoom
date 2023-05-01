
public class RiddleRepository
{
    public RiddleRepository()
    {
        Seed();
    }

    private List<Riddle> _riddleDB = new List<Riddle>();

    private int _count = 0;

    public bool AddRiddle(Riddle riddle)
    {
        if (riddle is null)
            return false;
        else
        {
            _count++;
            riddle.ID = _count;
            _riddleDB.Add(riddle);
            return true;
        }
    }

    public List<Riddle> GetRiddleByDifficulty(RiddleDifficulty difficulty)
    {
        return _riddleDB.Where(r => r.RiddleDifficulty == difficulty).ToList();
    }

    // public Riddle GetRandomRiddle(RiddleDifficulty difficulty) //? trying to access random riddle
    // {
    //     Random rnd = new Random();

    //     var randomValue = rnd.Next(listOfRiddles.Count());

    //     return listOfRiddles[randomValue];
    // }

    private void Seed()
    {
        var eRiddle = new Riddle
        {
            RiddleDifficulty = RiddleDifficulty.Easy,
            Questions = new List<Question>
            {
                new Question
                {
                    Title = "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?",
                    Answer = "Fire"
                },

                new Question
                {
                    Title = "What comes once in a minute, twice in a moment, but never in a thousand years?",
                    Answer = "M"
                },

                new Question
                {
                    Title = "What has many keys, but can't even open a single door?",
                    Answer = "piano"
                }
            }
        };

        var mRiddle = new Riddle
        {
            RiddleDifficulty = RiddleDifficulty.Medium,
            Questions = new List<Question>
            {
                new Question
                {
                    Title = "What is seen in the middle of March and April that can't be seen at the beginning or end of either month?",
                    Answer = "R"
                },

                new Question
                {
                    Title = "You have me today, Tomorrow you'll have more; As your time passes, I'm not easy to store; I don't take up space, But I'm only in one place; I am what you saw, But not what you see. What am I?",
                    Answer = "memories"
                }
            }
        };

        var hRiddle = new Riddle
        {
            RiddleDifficulty = RiddleDifficulty.Hard,
            Questions = new List<Question>
            {
                new Question
                {
                    Title = "Pronounced as 1 letter, And written with 3, 2 letters there are, and 2 only in me. I'm double, I'm single, I'm black blue, and gray, I'm read from both ends, and the same either way. What am I?",
                    Answer = "eye"
                },

                new Question
                {
                    Title = "What word in the English language does the following: the first two letters signify a male, the first three letters signify a female, the first four letters signify a great, while the entire world signifies a great woman. What is the word?",
                    Answer = "heroine"
                },
            }
        };
    }
}

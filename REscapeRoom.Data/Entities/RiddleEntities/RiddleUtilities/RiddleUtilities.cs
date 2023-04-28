
public static class RiddleUtilities
{
    public static List<EasyRiddle> AssignRiddleDifficulty()
    {
        var textListOfRiddles = File.ReadAllLines(@"C:\ElevenFiftyProjects\MyProjects\RiddleEscapeRoom\REscapeRoom.Data\Entities\RiddleEntities\EasyRiddle.txt");

        List<EasyRiddle> easyRiddleQuestions = new List<EasyRiddle>();

        for (int i = 0; i < textListOfEasyRiddles.Length; i++)
        {
            if (TextListOfEasyRiddles[i] == "|")
            {
                var easyRiddle = new EasyRiddle
                {
                    ID = int.Parse(textListOfEasyRiddles[++i]),
                    RiddleQuestion = textListOfEasyRiddles[++i],
                    RiddleAnswer = textListOfEasyRiddles[++i]
                };
                easyRiddleQuestions.Add(easyRiddle);
            }
        }
        return easyRiddleQuestions;
    }

    public static List<MediumRiddle> AssignRiddleDifficulty()
    {
        var textListOfRiddles = File.ReadAllLines(@"C:\ElevenFiftyProjects\MyProjects\RiddleEscapeRoom\REscapeRoom.Data\Entities\RiddleEntities\MediumRiddle.txt");

        List<MediumRiddle> mediumRiddleQuestions = new List<MediumRiddle>();

        for (int i = 0; i < textListOfMediumRiddles.Length; i++)
        {
            if (TextListOfMediumRiddles[i] == "|")
            {
                var mediumRiddle = new MediumRiddle
                {
                    ID = int.Parse(textListOfMediumRiddles[++i]),
                    RiddleQuestion = textListOfMediumRiddles[++i],
                    RiddleAnswer = textListOfMediumRiddles[++i]
                };
                mediumRiddleQuestions.Add(mediumRiddle);
            }
        }
        return mediumRiddleQuestions;
    }

        public static List<HardRiddle> AssignRiddleDifficulty()
    {
        var textListOfRiddles = File.ReadAllLines(@"C:\ElevenFiftyProjects\MyProjects\RiddleEscapeRoom\REscapeRoom.Data\Entities\RiddleEntities\HardRiddle.txt");

        List<HardRiddle> hardRiddleQuestions = new List<HardRiddle>();

        for (int i = 0; i < textListOfHardRiddles.Length; i++)
        {
            if (TextListOfHardRiddles[i] == "|")
            {
                var hardRiddle = new HardRiddle
                {
                    ID = int.Parse(textListOfHardRiddles[++i]),
                    RiddleQuestion = textListOfHardRiddles[++i],
                    RiddleAnswer = textListOfHardRiddles[++i]
                };
                hardRiddleQuestions.Add(hardRiddle);
            }
        }
        return hardRiddleQuestions;
    }

}

namespace Dictionary.Helpers
{
    public static class Dictionary
    {
        public static List<string> WordTypes = new List<string>()
        {
            "Nonus",
            "Pronouns",
            "Verbs"
        };

        public static Dictionary<string, List<string>> WordsByType = new Dictionary<string, List<string>>()
        {
            {"Nonus", new List<string>()
                {
                    "Computer", "Light", "Chair"
                }
            },
            {"Verbs", new List<string>()
                {
                    "Eat", "Sit", "Type"
                }
            }
        };
    }
}

namespace Dictionary.Helpers
{
    public static class Dictionary
    {
        public static List<string> WordTypes = new List<string>()
        {
            "Noun",
            "Pronoun",
            "Verb",
            "Adjective",
            "Adverb",
            "Preposition",
            "Conjuction",
            "Determiner",
            "Exclamation"
        };

        public static Dictionary<string, List<string>> WordsByType = new Dictionary<string, List<string>>()
        {
            {"Noun", new List<string>()
                {
                    "Computer", "Light", "Chair"
                }
            },
            {"Verb", new List<string>()
                {
                    "Eat", "Sit", "Type"
                }
            },
            {"Pronoun", new List<string>()
                {
                "He", "She"
                }
             },
            {"Adjective", new List<string>()
                {
                "Sweet", "Hot", "technical"
                }
             },
             {"Adverb", new List<string>()
                {
                "Slowly", "Rapidly", "Badly"
                }
             },
             {"Preposition", new List<string>()
                {
                "off the", "in front", "to"
                }
             },
             {"Conjuction", new List<string>()
                {
                "Or", "So", "Because"
                }
             },
             {"Determiner", new List<string>()
                {
                "The", "This", "That"
                }
             },
             {"Exclamation", new List<string>()
                {
                "Wow", "Oh", "Hooray"
                }
             }
        };
    }
}

namespace QuizBattle_Codealong
{
    public class QuizUtils
    {
        private static List<Question> _questions = new();
        private int _count = 0; // Antal Korrekta svar
        private int _TotalCount = 0; // 
        public static bool IsCompleted()
        {
            throw new NotImplementedException();
        }

        internal static void CheckAnswer(int answer)
        {
            throw new NotImplementedException();
        }

        internal static void DisplayQuestion()
        {
            throw new NotImplementedException();
        }

        internal static int GetAnswer()
        {
            throw new NotImplementedException();
        }

        internal static void SeedQuestions()
        {
            Choice[] choices =
            {
                new Choice("Q1.1","Två ben"),
                new Choice("Q1.2","Tre ben"),
                new Choice("Q1.3","Fyra ben")
            };
            _questions.Add(new Question("Hur många ben har en hund?", choices, "Q1.3"));

            Choice[] choices2 =
            {
                new Choice("Q1.1","Två ben"),
                new Choice("Q1.2","Tre ben"),
                new Choice("Q1.3","Tio ben"),
                new Choice("Q1.4","Åtta ben")              
            };
            _questions.Add(new Question("Hur många ben har en spindel?", choices, "Q1.4"));
        }

        internal static void WriteStatus()
        {
            throw new NotImplementedException();
        }
    }
}
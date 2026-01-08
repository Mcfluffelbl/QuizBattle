namespace QuizBattle_Codealong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuizUtils.SeedQuestions();

            Console.WriteLine("Quiz Battle");

            Console.WriteLine("Quiz Battle regler:");
            Console.WriteLine("1. Svara rätt för att få ett poäng");
            Console.WriteLine("2. ");

            while (!QuizUtils.IsCompleted())
            {
                QuizUtils.DisplayQuestion();
                int answer = QuizUtils.GetAnswer();

                QuizUtils.CheckAnswer(answer);

                QuizUtils.WriteStatus();
            }

            Console.WriteLine("Tack för att du spelade Quiz Battle");
        }
    }
}

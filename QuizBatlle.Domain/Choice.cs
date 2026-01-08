namespace QuizBattle_Codealong
{
    public class Choice
    {
        public Choice(string option, string code)
        {
            Option = option;
            Code = code;
        }

        public string Code { get; }
        public string Option { get; }      
    }
}
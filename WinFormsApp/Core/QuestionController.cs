namespace WinFormsApp.Core
{
    public class QuestionController
    {
        public Question AddNewQuestion(List<Question> questions)
        {
            var question = new Question() { Id = "A1", Title = "Текст вопроса", Answers = new List<Answer>() };
            questions.Add(question);
            return question;
        }

        public Answer AddNewAnswer(Question question)
        {
            var answer = new Answer() { Id = 1, Title = "Вариант ответа" };
            question.Answers.Add(answer);
            return answer;
        }
    }
}
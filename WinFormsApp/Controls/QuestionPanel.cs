using WinFormsApp.Core;

namespace WinFormsApp
{
    public partial class QuestionPanel : UserControl
    {
        private Question question;
        private bool isUpdating;

        public QuestionPanel()
        {
            InitializeComponent();
        }

        public void Build(Question question)
        {
            this.question = question;

            isUpdating = false;

            tbId.Text = question.Id;
            tbTitle.Text = question.Title;

            pnQuestion.Controls.Clear();
            foreach (var a in question.Answers)
            {
                var ap = new AnswerPanel();
                ap.Build(a);
                pnQuestion.Controls.Add(ap);
            }

            isUpdating = true;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (!isUpdating) return;

            question.Id = tbId.Text;
            question.Title = tbTitle.Text;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            new QuestionController().AddNewAnswer(question);
            Build(question);
        }
    }
}
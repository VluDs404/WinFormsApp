namespace WinFormsApp
{
    public partial class AnswerPanel : UserControl
    {
        private Answer answer;
        private bool isUpdating;

        public AnswerPanel()
        {
            InitializeComponent();
        }

        public void Build(Answer answer)
        {
            this.answer = answer;

            isUpdating = false;

            tbId.Text = answer.Id.ToString();
            tbTitle.Text = answer.Title;

            isUpdating = true;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (!isUpdating) return;

            answer.Id = Int32.Parse(tbId.Text);
            answer.Title = tbTitle.Text;
        }
    }
}
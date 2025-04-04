using WinFormsApp.Core;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Build()
        {
            pnMain.Controls.Clear();
            foreach (var q in questions)
            {
                var pn = new QuestionPanel();
                pn.Build(q);
                pnMain.Controls.Add(pn);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Тест|*.json" };
            if (sfd.ShowDialog() == DialogResult.OK)
                SaveLoader.Save(questions, sfd.FileName);
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Тест|*.json" };
            if (ofd.ShowDialog() == DialogResult.OK)
                questions = SaveLoader.Load<Question>(ofd.FileName);
            Build();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            new QuestionController().AddNewQuestion(questions);
            Build();
        }
    }
}
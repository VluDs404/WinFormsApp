namespace WinFormsApp
{
    partial class QuestionPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            tbTitle = new TextBox();
            tbId = new TextBox();
            btAdd = new PictureBox();
            pnQuestion = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)btAdd).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Варианты ответов";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(40, 3);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(207, 23);
            tbTitle.TabIndex = 2;
            tbTitle.TextChanged += tb_TextChanged;
            // 
            // tbId
            // 
            tbId.Location = new Point(3, 3);
            tbId.Name = "tbId";
            tbId.Size = new Size(33, 23);
            tbId.TabIndex = 3;
            tbId.TextChanged += tb_TextChanged;
            // 
            // btAdd
            // 
            btAdd.Image = Properties.Resources.add_icon;
            btAdd.Location = new Point(115, 32);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(15, 15);
            btAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            btAdd.TabIndex = 4;
            btAdd.TabStop = false;
            btAdd.Click += btAdd_Click;
            // 
            // pnQuestion
            // 
            pnQuestion.Location = new Point(3, 53);
            pnQuestion.Name = "pnQuestion";
            pnQuestion.Size = new Size(244, 91);
            pnQuestion.TabIndex = 5;
            // 
            // QuestionPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnQuestion);
            Controls.Add(btAdd);
            Controls.Add(tbId);
            Controls.Add(tbTitle);
            Controls.Add(label2);
            Name = "QuestionPanel";
            Size = new Size(250, 147);
            ((System.ComponentModel.ISupportInitialize)btAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox tbTitle;
        private TextBox tbId;
        private PictureBox btAdd;
        private FlowLayoutPanel pnQuestion;
    }
}

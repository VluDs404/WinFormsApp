namespace WinFormsApp
{
    partial class AnswerPanel
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
            tbId = new TextBox();
            tbTitle = new TextBox();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.Location = new Point(3, 3);
            tbId.Name = "tbId";
            tbId.Size = new Size(33, 23);
            tbId.TabIndex = 5;
            tbId.TextChanged += tb_TextChanged;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(42, 3);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(195, 23);
            tbTitle.TabIndex = 4;
            tbTitle.TextChanged += tb_TextChanged;
            // 
            // AnswerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbId);
            Controls.Add(tbTitle);
            Name = "AnswerPanel";
            Size = new Size(240, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private TextBox tbTitle;
    }
}

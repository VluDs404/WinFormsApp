namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btLoad = new ToolStripButton();
            btSave = new ToolStripButton();
            btAdd = new ToolStripButton();
            pnMain = new FlowLayoutPanel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btLoad, btSave, btAdd });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(546, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btLoad
            // 
            btLoad.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btLoad.Image = Properties.Resources.load_icon;
            btLoad.ImageTransparentColor = Color.Magenta;
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(23, 22);
            btLoad.Text = "Загрузить тест";
            btLoad.Click += btLoad_Click;
            // 
            // btSave
            // 
            btSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btSave.Image = Properties.Resources.save_icon;
            btSave.ImageTransparentColor = Color.Magenta;
            btSave.Name = "btSave";
            btSave.Size = new Size(23, 22);
            btSave.Text = "Сохранить тест";
            btSave.Click += btSave_Click;
            // 
            // btAdd
            // 
            btAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btAdd.Image = Properties.Resources.add_icon;
            btAdd.ImageTransparentColor = Color.Magenta;
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(23, 22);
            btAdd.Text = "Добавить вопрос";
            btAdd.Click += btAdd_Click;
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnMain.Location = new Point(12, 28);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(523, 399);
            pnMain.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 436);
            Controls.Add(pnMain);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Simple Test";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btSave;
        private ToolStripButton btLoad;
        private FlowLayoutPanel pnMain;
        private ToolStripButton btAdd;
    }
}

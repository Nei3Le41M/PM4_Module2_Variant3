namespace Task_12._12._25
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxTests = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            buttonRun = new Button();
            labelResult = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxTests
            // 
            comboBoxTests.BackColor = Color.FromArgb(51, 51, 76);
            comboBoxTests.FlatStyle = FlatStyle.Flat;
            comboBoxTests.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTests.ForeColor = Color.White;
            comboBoxTests.FormattingEnabled = true;
            comboBoxTests.Location = new Point(12, 78);
            comboBoxTests.Name = "comboBoxTests";
            comboBoxTests.Size = new Size(457, 33);
            comboBoxTests.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 60);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // buttonRun
            // 
            buttonRun.BackColor = Color.FromArgb(51, 51, 76);
            buttonRun.FlatAppearance.BorderSize = 0;
            buttonRun.FlatStyle = FlatStyle.Flat;
            buttonRun.ForeColor = Color.White;
            buttonRun.Location = new Point(12, 130);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(94, 29);
            buttonRun.TabIndex = 2;
            buttonRun.Text = "Запустить";
            buttonRun.UseVisualStyleBackColor = false;
            buttonRun.Click += buttonRun_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.ForeColor = Color.White;
            labelResult.Location = new Point(12, 192);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(50, 20);
            labelResult.TabIndex = 3;
            labelResult.Text = "label2";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(902, 673);
            Controls.Add(labelResult);
            Controls.Add(buttonRun);
            Controls.Add(panel1);
            Controls.Add(comboBoxTests);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTests;
        private Panel panel1;
        private Label label1;
        private Button buttonRun;
        private Label labelResult;
    }
}
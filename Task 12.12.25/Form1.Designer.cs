namespace Task_12._12._25
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
            label1 = new Label();
            textBox1 = new TextBox();
            buttonCalculate = new Button();
            labelResults = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(628, 35);
            label1.TabIndex = 0;
            label1.Text = "Введите данные, разделенные запятыми или пробел.";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 51, 76);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(544, 27);
            textBox1.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.FromArgb(51, 51, 76);
            buttonCalculate.FlatAppearance.BorderSize = 0;
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.ForeColor = Color.White;
            buttonCalculate.Image = Properties.Resources.free_icon_calculator_3626508__2_;
            buttonCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCalculate.Location = new Point(12, 179);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(200, 60);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "  Вычислить";
            buttonCalculate.TextAlign = ContentAlignment.MiddleLeft;
            buttonCalculate.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.ForeColor = Color.White;
            labelResults.Location = new Point(12, 261);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(54, 18);
            labelResults.TabIndex = 3;
            labelResults.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 60);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(465, 27);
            label2.TabIndex = 0;
            label2.Text = "калькулятор статистических функций";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(900, 676);
            Controls.Add(panel1);
            Controls.Add(labelResults);
            Controls.Add(buttonCalculate);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonCalculate;
        private Label labelResults;
        private Panel panel1;
        private Label label2;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_12._12._25
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadTests();
        }

        private void LoadTests()
        {
            comboBoxTests.Items.AddRange(TestRunner.Tests.Keys.ToArray());
            comboBoxTests.SelectedIndex = 0;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (comboBoxTests.SelectedItem == null)
            {
                labelResult.Text = "Выберите тест.";
                return;
            }

            string selected = comboBoxTests.SelectedItem.ToString();
            double[] data = TestRunner.Tests[selected];

            try
            {
                double mean = MathFunctions.Mean(data);
                double median = MathFunctions.Median(data);
                double mode = MathFunctions.Mode(data);
                double std = MathFunctions.StdDev(data);
                double geom = MathFunctions.GeometricMean(data);

                labelResult.Text =
                    $"Среднее: {mean:F3}\n" +
                    $"Медиана: {median:F3}\n" +
                    $"Мода: {mode:F3}\n" +
                    $"Геом. среднее: {geom:F3}\n" +
                    $"Ст. отклонение: {std:F3}\n\n" +
                    "Тест выполнен успешно.";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"атОшибка: {ex.Message}";
            }
        }
    }
}

using System.Globalization;

namespace Task_12._12._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelResults.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var tokens = textBox1.Text
                    .Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 0)
                {
                    MessageBox.Show("����������, ������� ���� �� ��� �����.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double[] numbers = new double[tokens.Length];
                for (int i = 0; i < tokens.Length; i++)
                {
                    string t = tokens[i].Trim();
                    if (!double.TryParse(t, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                    {
                        MessageBox.Show($"������������ ������ �����: \"{t}\". ����������� �����, ���������� �������� ��� ������� (��� ����������).",
                                        "������ �������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    numbers[i] = val;
                }

                if (numbers.Length == 1)
                {
                    MessageBox.Show("������� ��� ������� ��� ����� � �������������� ������� ��� ������ ����� �� ������������.",
                                    "������������ ������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var sorted = numbers.OrderBy(n => n).ToArray();
                double mean = numbers.Average();
                double median = GetMedian(sorted);

                string geomMeanStr;
                if (numbers.Any(n => n <= 0))
                {
                    geomMeanStr = "N/A (���� <= 0)";
                }
                else
                {
                    double geometricMean = Math.Pow(numbers.Aggregate(1.0, (a, b) => a * b), 1.0 / numbers.Length);
                    geomMeanStr = geometricMean.ToString("G17", CultureInfo.InvariantCulture);
                }

                double variance = numbers.Average(v => Math.Pow(v - mean, 2));
                double stdDev = Math.Sqrt(variance);
                double sum = numbers.Sum();
                double min = numbers.Min();
                double max = numbers.Max();
                double range = max - min;
                double mode = GetMode(sorted);

                labelResults.Text =
                    $"����: {mode}\n\n" +
                    $"�������: {median}\n\n" +
                    $"������� ��������������: {mean:G6}\n\n" +
                    $"������� ��������������: {geomMeanStr}\n\n" +
                    $"����������� ����������: {stdDev:G6}\n\n" +
                    $"���������: {variance:G6}\n\n" +
                    $"�����: {sum:G6}\n\n" +
                    $"����������: {max}\n\n" +
                    $"����������: {min}\n\n" +
                    $"Range: {range}\n\n" +
                    $"������������� ������: {string.Join("; ", sorted.Select(n => n.ToString(CultureInfo.InvariantCulture)))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetMedian(double[] sorted)
        {
            int n = sorted.Length;
            if (n % 2 == 1)
                return sorted[n / 2];
            else
                return (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
        }

        private double GetMode(double[] sorted)
        {
            return sorted
                .GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.Key)
                .First()
                .Key;
        }
    }
}

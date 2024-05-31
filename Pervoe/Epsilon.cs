using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создание нового объекта Chart
            Chart graph = new Chart();
            graph.Size = new Size(800, 600);
            graph.Parent = this;

            // Добавление области для построения графика
            ChartArea area = new ChartArea();
            graph.ChartAreas.Add(area);

            // Создание нового объекта Series для данных
            Series series = new Series();
            graph.Series.Add(series);

            // Задание интервала значений по оси X
            area.AxisX.Minimum = -10;
            area.AxisX.Maximum = 10;

            // Ввод формулы с клавиатуры
            string formula = Prompt.ShowDialog("Введите формулу для построения графика", "Формула");
            
            // Построение графика
            for (double x = -10; x <= 10; x += 0.1)
            {
                double y = CalculateFormula(formula, x);
                series.Points.AddXY(x, y);
            }
        }

        // Функция для вычисления значения формулы
        private double CalculateFormula(string formula, double x)
        {
            // Реализация вычисления значения формулы
            // Например, можно использовать библиотеку NCalc для вычисления математических выражений
            throw new NotImplementedException();
        }
    }

    // Класс для создания диалогового окна для ввода формулы
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
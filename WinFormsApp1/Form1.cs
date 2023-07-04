using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public double resultx, resulty, resultz, resultA, resultB, resultC, resultD, distance;
        public string reshenie = "";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// calculateButton_Click выполняет действия по нажатию кнопки "Рассчитать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = textBox2.ForeColor = textBox3.ForeColor = textBox4.ForeColor = textBox5.ForeColor = textBox6.ForeColor = textBox7.ForeColor = textBox8.ForeColor = Color.Black;
            try
            {
                // приравнивание textBox к переменной result
                resultx = EvaluateExpression(textBox1);
                resulty = EvaluateExpression(textBox2);
                resultz = EvaluateExpression(textBox3);
                resultA = EvaluateExpression(textBox4);
                resultB = EvaluateExpression(textBox5);
                resultC = EvaluateExpression(textBox6);
                resultD = EvaluateExpression(textBox7);
                distance = Math.Abs(resultA * resultx + resultB * resulty + resultC * resultz + resultD) / Math.Sqrt(resultA * resultA + resultB * resultB + resultC * resultC); // рассчёт по формуле
                textBox8.Text = "Расстояние от точки (" + resultx + ", " + resulty + ", " + resultz + ") до плоскости " + resultA + "x + " + resultB + "y + " + resultC + "z + " + resultD + " = 0; равно " + distance; // вывод результата на форму
                reshenie = "Решение: " + resultA + " * " + resultx + " + " + resultB + " * " + resulty + " + " + resultC + " * " + resultz + " + " + resultD + " / " + resultA + " * " + resultA + " + " + resultB + " * " + resultB + " + " + resultC + " * " + resultC + " = " + distance; // решение типа string
                if (reshenie.Contains("\u221E"))
                {
                    textBox8.Text = "На ноль делить нельзя"; // вывод сообщения
                    reshenie = ""; // обнуление переменной
                    distance = 0.0; // обнуление переменной
                }
                MessageBox.Show("Рассчёт выполнен!");
            }
            catch (Exception ex)
            {
                textBox8.Text = "Ошибка: " + ex.Message; // вывод ошибки
            }
        }

        /// <summary>
        /// clearButton_Click выполняет действия по нажатию кнопки "Очистить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // очистка textBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            resultx = resulty = resultz = resultA = resultB = resultC = resultD = 0.0; // очистка переменных типа double
            reshenie = ""; // очистка переменных типа string
        }

        /// <summary>
        /// exitButton_Click выполняет действия по нажатию кнопки "Выйти"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // закрывает приложение
        }

        /// <summary>
        /// wordButton_Click выполняет действия по нажатию кнопки "Показать в Word"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wordButton_Click(object sender, EventArgs e)
        {
            Word.Application word = new(); // создание объекта Word
            Word.Document doc = word.Documents.Add(); // создание нового документа Word
            if (textBox8.Text == "На ноль делить нельзя")
            {
                doc.Paragraphs[1].Range.Text = textBox8.Text; // вывод текста
            }
            else
            {
                doc.Paragraphs[1].Range.Text = "x = " + resultx + "\ny = " + resulty + "\nz = " + resultz + "\nA = " + resultA + "\nB = " + resultB + "\nC = " + resultC + "\nD = " + resultD + "\n" + this.textBox8.Text + "\n" + reshenie + "\n" + "Ответ: " + distance; // вывод текста
            }
            word.Visible = true;
        }

        /// <summary>
        /// excelButton_Click выполняет действия по нажатию кнопки "Показать в Excel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelButton_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new(); // создание объекта Excel
            Excel.Workbook workbook = excel.Workbooks.Add(); // создание новой книги Excel
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.ActiveSheet; // выбор активного листа
            // вывод текста на ячейку
            if (textBox8.Text == "На ноль делить нельзя")
            {
                sheet.Cells[1, 1].Value = textBox8.Text;
            }
            else
            {
                sheet.Cells[1, 1].Value = "x = " + resultx;
                sheet.Cells[2, 1].Value = "y = " + resulty;
                sheet.Cells[3, 1].Value = "z = " + resultz;
                sheet.Cells[4, 1].Value = "A = " + resultA;
                sheet.Cells[5, 1].Value = "B = " + resultB;
                sheet.Cells[6, 1].Value = "C = " + resultC;
                sheet.Cells[7, 1].Value = "D = " + resultD;
                sheet.Cells[1, 2].Value = textBox8.Text;
                sheet.Cells[2, 2].Value = reshenie;
                sheet.Cells[3, 2].Value = "Ответ: " + distance;
            }
            sheet.Columns.AutoFit(); // выравнивание столбцов
            sheet.Rows.AutoFit(); // выравнивание строк
            excel.Visible = true;
        }

        /// <summary>
        /// EvaluateExpression преобразует выражения в числа
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static double EvaluateExpression(TextBox expression)
        {
            try
            {
                expression.Text = expression.Text.Replace(" ", ""); // удаление пробелов из выражения
                System.Data.DataTable dt = new(); // создание объекта для вычисления математических выражений
                var result = dt.Compute(expression.Text, ""); // вычисление математических выражений
                return Convert.ToDouble(result); // возврат результата
            }
            catch (Exception ex)
            {
                expression.ForeColor = Color.Red;
                expression.Text = "0";
                MessageBox.Show($"Ошибка в {expression}: " + ex.Message + "Все поля с ошибками были заменены на 0"); // вывод ошибки
                return 0.0;
            }
        }

        /// <summary>
        /// textBox1_KeyPress выполняет действие по нажатию кнопки во время фокусировки на textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox2.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox2_KeyPress выполняет действие по нажатию кнопки во время фокусировки на textBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox3.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox3_KeyPress выполняет действие по нажатию кнопки во время фокусировки на textBox3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox4.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox4_KeyPress выполняет действие по нажатию кнопки во время фокусировки на textBox4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox5.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox5_KeyPress выполняет действие по нажатию кнопки во время фокусировки на textBox5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox6.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox6_KeyPress выполняет действие по нажатию кнопки во время фокусировки на textBox6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox7.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox7_KeyPress выполняет действие по нажатию кнопки во время фокусировки на textBox7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                calculateButton.PerformClick(); // выполняет действие, аналогичное нажатию кнопки
            }
        }
    }
}
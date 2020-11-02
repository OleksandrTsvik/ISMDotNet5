using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixLibrary;

namespace WinForms
{
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelColumnCount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void VisibleLabelsFalse()
        {
            labelCountPositiveElements.Visible = false;
            labelMoreOneMaximumNumbers.Visible = false;
            labelCountColumnsWithoutZeros.Visible = false;
            labelCountRowsWithZeros.Visible = false;
            labelNumberRowMaxIdenticalElements.Visible = false;
            labelMultiplicationRowsWithoutNegativeElements.Visible = false;
            labelMaxSumsDiagonalsParallelMain.Visible = false;
            labelSumColumnsDoNotNegativeElements.Visible = false;
            labelMinSumsModulesElementsDiagonalsParallelLateral.Visible = false;
            labelCalculateSumColumnsNegativeElement.Visible = false;
        }

        private void buttonTransposeMatrix_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            int[,] transposeMatrix = matrix.TransposeMatrix();
            DataGridMatrix.PrintDataGridViewMatrix(transposeMatrix);

            numericUpDownRowCount.Value = transposeMatrix.GetLength(0);
            numericUpDownColumnCount.Value = transposeMatrix.GetLength(1);

            VisibleLabelsFalse();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            VisibleLabelsFalse();

            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);

            matrix.FillRandomNumbers();
            DataGridMatrix.FillDataGridView(matrix);
        }

        private void buttonCountPositiveElements_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            labelCountPositiveElements.Text = "= " + matrix.CountPositiveElements().ToString();
            labelCountPositiveElements.Visible = true;
        }

        private void buttonMoreOneMaximumNumbers_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            int count = 1;
            int max = matrix.MoreOneMaximumNumbers(ref count);
            if (count == 1)
                labelMoreOneMaximumNumbers.Text = "- Error!  -->  Кожне число зустрічається лише один раз!";
            else
                labelMoreOneMaximumNumbers.Text = "= " + max.ToString();

            labelMoreOneMaximumNumbers.Visible = true;
        }

        private void buttonCountRowsWithoutZeros_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            labelCountColumnsWithoutZeros.Text = "= " + matrix.CountColumnsWithoutZeros().ToString();
            labelCountColumnsWithoutZeros.Visible = true;
        }

        private void buttonCountRowsWithZeros_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            labelCountRowsWithZeros.Text = "= " + matrix.CountRowsWithZeros().ToString();
            labelCountRowsWithZeros.Visible = true;
        }

        private void buttonNumberRowMaxIdenticalElements_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            int NumberRowMaxIdenticalElements = matrix.NumberRowMaxIdenticalElements();
            if (NumberRowMaxIdenticalElements == -1)
                labelNumberRowMaxIdenticalElements.Text = "- Error!  -->  Кожен рядок має різні числа!";
            else
                labelNumberRowMaxIdenticalElements.Text = "= " + NumberRowMaxIdenticalElements.ToString();
            labelNumberRowMaxIdenticalElements.Visible = true;
        }

        private void buttonMultiplicationRowsWithoutNegativeElements_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            int countRowsNegativeElements = 0;
            int rowCount = Convert.ToInt32(numericUpDownRowCount.Value);
            int[] multiArr = matrix.MultiplicationRowsWithoutNegativeElements(ref countRowsNegativeElements);
            string str = "= ";
            if (countRowsNegativeElements == rowCount)
                str = "- Error!  -->  Кожен рядок містить один або більше від’ємних елементів!";
            else
            {
                for (int i = 0; i < rowCount; i++)
                {
                    if (multiArr[i] != -1 && i < rowCount - 1)
                        str += $"MultiplicationRow({i}) = " + multiArr[i].ToString() + "; ";
                    if (multiArr[i] != -1 && i == rowCount - 1)
                        str += $"MultiplicationRow({i}) = " + multiArr[i].ToString();
                }
            }
            labelMultiplicationRowsWithoutNegativeElements.Text = str;
            labelMultiplicationRowsWithoutNegativeElements.Visible = true;
        }

        private void buttonMaxSumsDiagonalsParallelMain_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            labelMaxSumsDiagonalsParallelMain.Text = "= " + matrix.MaxSumsDiagonalsParallelMain().ToString();
            labelMaxSumsDiagonalsParallelMain.Visible = true;
        }

        private void buttonSumColumnsDoNotNegativeElements_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            int countColumnsNegativeElements = 0;
            int colCount = Convert.ToInt32(numericUpDownColumnCount.Value);
            int[] sumArr = matrix.SumColumnsDoNotNegativeElements(ref countColumnsNegativeElements);
            string str = "= ";
            if (countColumnsNegativeElements == colCount)
                str = "- Error!  -->  Кожен стовпець містить один або більше від’ємних елементів!";
            else
            {
                for (int i = 0; i < colCount; i++)
                {
                    if (sumArr[i] != -1 && i < colCount - 1)
                        str += $"SumColumn({i}) = " + sumArr[i].ToString() + "; ";
                    if (sumArr[i] != -1 && i == colCount - 1)
                        str += $"SumColumn({i}) = " + sumArr[i].ToString();
                }
            }
            labelSumColumnsDoNotNegativeElements.Text = str;
            labelSumColumnsDoNotNegativeElements.Visible = true;
        }

        private void buttonCalculateSumColumnsNegativeElement_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            int countColumnsNegativeElements = 0;
            int colCount = Convert.ToInt32(numericUpDownColumnCount.Value);
            string[] sumArr = matrix.CalculateSumColumnsNegativeElement(ref countColumnsNegativeElements);
            string str = "= ";
            if (countColumnsNegativeElements == colCount)
                str = "- Error!  -->  Кожен стовпець не містить від’ємних елементів!";
            else
            {
                for (int i = 0; i < colCount; i++)
                {
                    if (sumArr[i] != "*" && i < colCount - 1)
                        str += $"SumColumn({i}) = " + sumArr[i] + "; ";
                    if (sumArr[i] != "*" && i == colCount - 1)
                        str += $"SumColumn({i}) = " + sumArr[i];
                }
            }
            labelCalculateSumColumnsNegativeElement.Text = str;
            labelCalculateSumColumnsNegativeElement.Visible = true;
        }

        private void buttonMinSumsModulesElementsDiagonalsParallelLateral_Click(object sender, EventArgs e)
        {
            MyMatrix matrix = new MyMatrix(Convert.ToInt32(numericUpDownRowCount.Value), Convert.ToInt32(numericUpDownColumnCount.Value));

            DataGridViewVisualizer DataGridMatrix = new DataGridViewVisualizer(dataGridViewMatrix);
            DataGridMatrix.ReadDataGridView(matrix);

            labelMinSumsModulesElementsDiagonalsParallelLateral.Text = "= " + matrix.MinSumsModulesElementsDiagonalsParallelLateral().ToString();
            labelMinSumsModulesElementsDiagonalsParallelLateral.Visible = true;
        }
    }
}

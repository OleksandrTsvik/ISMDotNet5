using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixLibrary
{
    public class DataGridViewVisualizer
    {
        protected DataGridView DataGrid;
        
        public DataGridViewVisualizer(DataGridView dataGrid)
        {
            DataGrid = dataGrid;
        }
        
        public void Initialization(int rowCount, int columnCount)
        {
            DataGrid.ColumnCount = columnCount;
            DataGrid.RowCount = rowCount;

            for (int i = 0; i < columnCount; i++)
            {
                DataGrid.Columns[i].Width = 45;
            }
            DataGrid.RowHeadersWidth = 50;
        }

        public void NumerateRowsAndColumns()
        {
            for (int i = 0; i < DataGrid.ColumnCount; i++)
                DataGrid.Columns[i].HeaderCell.Value = i.ToString();

            for (int j = 0; j < DataGrid.RowCount; j++)
                DataGrid.Rows[j].HeaderCell.Value = j.ToString();
        }

        public void FillDataGridView(MyMatrix matrix)
        {
            int[,] matr = matrix.GetMatrix();
            Initialization(matr.GetLength(0), matr.GetLength(1));
            NumerateRowsAndColumns();
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                    DataGrid[j, i].Value = matr[i, j];
        }

        public void ReadDataGridView(MyMatrix matrix)
        {
            int[,] matr = matrix.GetMatrix();
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                    matr[i, j] = int.Parse(DataGrid[j, i].Value.ToString());
        }

        public void PrintDataGridViewMatrix(int[,] matr)
        {
            Initialization(matr.GetLength(0), matr.GetLength(1));
            NumerateRowsAndColumns();
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                    DataGrid[j, i].Value = matr[i, j];
        }
    }
}

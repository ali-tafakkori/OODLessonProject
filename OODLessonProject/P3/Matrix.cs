using System;

namespace OODLessonProject.P3
{
    class Matrix
    {
        private int[,] data;

        public Matrix()
        {
            data = new int[0, 0];
        }

        public Matrix(int rows, int cols)
        {
            data = new int[rows, cols];
        }
        public Matrix(Matrix other)
        {
            data = other.data;
        }

        public int RowsCount
        {
            get
            {
                return data.GetLength(0);
            }
        }
        public int ColumnsCount
        {
            get
            {
                return data.GetLength(1);
            }
        }

        public int this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= RowsCount || col < 0 || col >= ColumnsCount)
                    throw new Exception("Index out of range");
                return data[row, col];
            }
            set
            {
                if (row < 0 || row >= RowsCount || col < 0 || col >= ColumnsCount)
                    throw new Exception("Index out of range");
                data[row, col] = value;
            }
        }
    }
}

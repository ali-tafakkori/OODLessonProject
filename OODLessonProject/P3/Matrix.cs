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

        public int GetRowsCount()
        {
            return data.GetLength(0);
        }

        public int GetColumnsCount()
        {
            return data.GetLength(1);
        }

        public int GetValue(int row, int col)
        {
            return data[row, col];
        }

        public void SetValue(int row, int col, int value)
        {
            data[row, col] = value;
        }
    }
}

using System;
using System.Text;

namespace OOP_Lab_3
{
    public class MyMatrix
    {
        // Fields

        protected double[,] m;


        // Constructors

        public MyMatrix(MyMatrix other)
        {
            m = (double[,])other.m.Clone();
        }


        public MyMatrix(double[,] mtx)
        {
            m = (double[,])mtx.Clone();
        }


        public MyMatrix(double[][] mtx)
        {
            if (mtx == null)
            {
                throw new ArgumentException("Jagged array can't be null");
            }

            FillFromJagged(mtx);
        }


        public MyMatrix(string[] rows)
        {
            if (rows == null)
            {
                throw new ArgumentException("Array of strings can't be null");
            }

            FillFromStringRows(rows);
        }


        public MyMatrix(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("Input string can't be null");
            }
            string[] rows = text.Trim().Split("\n");

            FillFromStringRows(rows);
        }


        // Properties

        public int Height
        {
            get
            {
                return m.GetLength(0);
            }
        }


        public int Width
        {
            get
            {
                return m.GetLength(1);
            }
        }


        // Static Methods

        public static MyMatrix operator +(MyMatrix first, MyMatrix second)
        {
            if ((first.Height != second.Height)
              ||(first.Width != second.Width))
            {
                throw new ArgumentException("(Operator +) Matrices should be equally sized");
            }

            double[,] result = new double[first.Height, first.Width];


            for (int i = 0; i < first.Height; i++)
            {
                for (int j = 0; j < first.Width; j++)
                {
                    result[i, j] = first.m[i, j] + second.m[i, j];
                }
            }
            
            return new MyMatrix(result);
        }


        public static MyMatrix operator *(MyMatrix first, MyMatrix second)
        {
            if (first.Width != second.Height)
            {
                throw new ArgumentException("Matrices can't be multiplied");
            }

            double[,] result = new double[first.Height, second.Width];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int k = 0; k < first.Width; k++)
                    {
                        result[i, j] += first.m[i, k] * second.m[k, j];
                    }
                }
            }

            return new MyMatrix(result);
        }


        // Private Methods

        private void FillFromJagged(double[][] mtx)
        {
            int dim = mtx[0].Length;
            for (int i = 1; i < mtx.Length; i++)
            {
                if (mtx[i].Length != dim)
                {
                    throw new ArgumentException("Jagged array should be rectangular");
                }
            }

            m = new double[mtx.Length, mtx[0].Length];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = mtx[i][j];
                }
            }
        }


        private void FillFromStringRows(string[] rows)
        {
            double[][] tmp_mtx = new double[rows.Length][];
            for (int i = 0; i < tmp_mtx.Length; i++)
            {
                tmp_mtx[i] = Array.ConvertAll(rows[i].Trim().Split(), double.Parse);
            }

            FillFromJagged(tmp_mtx);
        }


        // Public Methods

        public int GetHeight()
        {
            return m.GetLength(0);
        }


        public int GetWidth()
        {
            return m.GetLength(1);
        }


        public double this[int i, int j]
        {
            get
            {
                return m[i, j];
            }
            set
            {
                m[i, j] = value;
            }
        }


        public double GetElement(int i, int j)
        {
            return m[i, j];
        }


        public void SetElement(int i, int j, double val)
        {
            m[i, j] = val;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    sb.Append(m[i, j]);
                    sb.Append("\t");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append("\n");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}

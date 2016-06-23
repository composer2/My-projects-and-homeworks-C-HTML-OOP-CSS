using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassesAndStructs
{
    public class Matrix<T> where T : struct, IConvertible
    {
        private T[,] matrix;

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public Matrix(int rows, int cols)
        {
            if (rows < 1 || cols < 1)
            {
                throw new AggregateException("The size must a positive numbers");
            }
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("Dimentions mismatch.");
            }

            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = Sum(first[i, j], second[i, j]);
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("Dimentions mismatch.");
            }

            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = Substract(first[i, j], second[i, j]);
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols != second.Rows)
            {
                throw new ArgumentException("Dimentions mismatch.");
            }

            Matrix<T> result = new Matrix<T>(first.Rows, second.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = default(T);
                    for (int k = 0; k < first.Cols; k++)
                    {
                        result[i, j] = Sum(result[i, j], Multiply(first.matrix[i, k], second[k, j]));
                    }
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> x)
        {
            for (int i = 0; i < x.Rows; i++)
            {
                for (int j = 0; j < x.Cols; j++)
                {
                    if ((decimal)Convert.ChangeType(x.matrix[i, j], typeof(decimal)) != 0.0m)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> x)
        {
            return x ? false : true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string separator = " ";
            for (int i = 0; i < this.Rows; i++)
            {
                for (int k = 0; k < this.Cols; k++)
                {
                    result.Append(this.matrix[i, k]).Append(separator);
                }
                result.Length -= separator.Length;
                result.Append(Environment.NewLine);
            }
            result.Length -= Environment.NewLine.Length;

            return result.ToString();
        }

        private static T Sum(T t1, T t2)
        {
            return (T)((dynamic)t1 + t2);
            //return (T)((IConvertible)(first.ToDecimal(CultureInfo.InvariantCulture) + second.ToDecimal(CultureInfo.InvariantCulture))).ToType(typeof(T), CultureInfo.InvariantCulture);

        }
        private static T Multiply(T t1, T t2)
        {
            return (T)((dynamic)t1 * t2);
        }

        private static T Substract(T t1, T t2)
        {
            return (T)((dynamic)t1 - t2);
        }

        private void ValidateIndexes(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                throw new ArgumentException("Invalid indexes.");
            }
        }
    }
}

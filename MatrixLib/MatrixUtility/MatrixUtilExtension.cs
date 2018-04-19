using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib.MatrixUtility
{
    // i.e. 
    // Matrix<int> matrix = new Matrix<int>();
    // int number = matrix.getCalcResult();

    public class Matrix<T> where T : new()
    {
        public T[,] values;
    }

    public static class MatrixExtension
    {
        public static T getCalcResult<T>(this Matrix<T> matrix) where T : new()
        {
            T result = new T();
            // TO-DO
            return result;
        }
    }

}
namespace HW1;


public class Array2D
{
    private int[,] _matrix;
    private int _sum;
    private int _row;
    private int _col;

    //Конструктор
    public Array2D(int rows, int colums)
    {
        _matrix = new int[rows, colums];
        _sum = 0;
        _row = rows;
        _col = colums;
    }


    //Індексатор для ініціалізації масиву
    public int this[int row, int col]
    {
        get
        {
            return _matrix[row, col];
        }
        set
        {
            _sum -= _matrix[row, col];
            _matrix[row, col] = value;
            _sum += value;
            
        }
    }
    
    //Властивість для читання суми елементів масиву
    public int SumOfElements
    {
        get
        {
            return _sum;
        }
    }

    //Індексатор, що повертає середньоквадратичне значення всіх
    // елементів заданого індексом рядка масиву
    public double this[int row]
    {
        get
        {
            double result = 0.0;
            for (int i = 0; i < _col; i++)
            {
                result += _matrix[row, i]*_matrix[row, i];
            }

            return Math.Sqrt(result / _col);
        }
    }
    
}
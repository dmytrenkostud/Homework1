namespace HW1;

class Program
{
    static void Main()
    {
        Array2D my_arr = new Array2D(2, 2);
        my_arr[0, 1] = 10;
        my_arr[0, 0] = 3;
        my_arr[0, 1] = 8;
        my_arr[1, 0] = 5;
        my_arr[1, 1] = 9;
        Console.WriteLine(my_arr.SumOfElements);
        Console.WriteLine(my_arr[1]);

    }
}
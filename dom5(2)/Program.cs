using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        try
        {
            for (int i = 0; i <= array.Length; i++)
            {
                int element = array[i];
                Console.WriteLine($"Элемент {i}: {element}");
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Произошла ошибка: выход за пределы массива.");
        }
        finally
        {
            Console.WriteLine("Завершение обработки массива.");
        }
    }
}

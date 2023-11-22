
internal class Program
{
    private static void Main(string[] args)
    {
        // Создает  из имеющегося массива строк array1 формирует массив array2 из строк, 
        //длина которых меньше либо равна 3 символа.
        void SecondArray(string[] array1, string[] array2)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length <= 3)
                {
                    array2[count] = array1[i];
                    count++;
                }
            }
        }
        //Выводит на печать массив array
        void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        string[] arrOne = new string[6] { "789", "45", "qwerty", "war", "insert", "R" };
        string[] arrTwo = new string[arrOne.Length];
        SecondArray(arrOne, arrTwo);
        PrintArray(arrOne);
        PrintArray(arrTwo);
    }
}
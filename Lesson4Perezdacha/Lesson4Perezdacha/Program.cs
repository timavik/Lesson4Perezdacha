namespace Lesson4Perezdacha
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Часть 1");

            object[] array = { 42, "Hello", 3.14, true, 'A', new int[] { 1, 2, 3 } };

            Console.WriteLine("Использование for-цикла:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Элемент {i}: {array[i]}");
            }

            Console.WriteLine("\nИспользование foreach-цикла:");
            foreach (var item in array)
            {
                Console.WriteLine($"Элемент: {item}");
            }

            Console.WriteLine("\nЧасть 2");
            for (int i = 10; i <= 99; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            static void BubbleSort()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите размер массива \n");

                int.TryParse(Console.ReadLine(), out int Size);

                int[] Array = new int[Size];

                int Temp;

                Random random = new Random((int)DateTime.Now.Ticks);
                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = random.Next(1, 100);
                }


                Console.WriteLine("Массив \n");

                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write(Array[i] + "   ");
                }
                Console.WriteLine("\n");

                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length; j++)
                    {
                        if (Array[i] < Array[j])
                        {
                            Temp = Array[i];
                            Array[i] = Array[j];
                            Array[j] = Temp;
                        }
                    }
                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Сортировка пузырьком \n");

                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write(Array[i] + "   ");
                }
                Console.ResetColor();
            }
            
            static void SelectionSort()
            {
                // Создаем массив
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите размер массива \n");

                int.TryParse(Console.ReadLine(), out int Size);
                // Массив создан
                int[] Array = new int[Size];

                int Min;
                int Temp;

                // Заполняем массив рандомными числами
                Random random = new Random((int)DateTime.Now.Ticks);
                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = random.Next(1, 100);
                }

                // Выводим массив
                Console.WriteLine("Массив \n");

                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write(Array[i] + "   ");
                }
                Console.WriteLine();
                
                // Находим наименьший элемент массива
                for (int i = 0; i < Array.Length; i++)
                {
                    Min = i;

                    for (int j = i + 1; j < Array.Length; j++)
                    {
                        if (Array[j] < Array[Min])
                        {
                            Min = j;
                        }
                    }
                    // Сортируем массив
                    if (Min != i)
                    {
                        Temp = Array[i];
                        Array[i] = Array[Min];
                        Array[Min] = Temp;
                    }
                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("Сортировка выбором \n");

                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write(Array[i] + "   ");
                }
                Console.ResetColor();
            }

            static void InsertSort()
            {
                // Создаем массив
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите размер массива \n");

                int.TryParse(Console.ReadLine(), out int Size);
                Console.WriteLine("\n");

                int[] Array = new int[Size];

                int InsertNumber;
                int Temp;


                // Заполняем массив случайными числами
                Random random = new Random((int)DateTime.Now.Ticks);
                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = random.Next(1, 100);
                }


                // Выводим массив
                Console.WriteLine("Массив \n");

                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write(Array[i] + "   ");
                }
                Console.WriteLine("\n");


                // Сортируем массив
                for (int i = 1; i < Array.Length; i++)
                {
                    InsertNumber = i;

                    while (InsertNumber > 0 && Array[InsertNumber] < Array[InsertNumber - 1])
                    {
                        Temp = Array[InsertNumber - 1];
                        Array[InsertNumber - 1] = Array[InsertNumber];
                        Array[InsertNumber] = Temp;

                        InsertNumber--;
                    }
                }


                // Выводим отсортированый массив
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Сортировка вставкой \n");

                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write(Array[i] + "   ");
                }
                Console.ResetColor();
            }
            





        }
    }
}



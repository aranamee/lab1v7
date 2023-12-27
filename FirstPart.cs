using System;

namespace lab1v7
{
    public class FirstPart
    {
        // Метод для вывода массива на консоль
        public void PrintArray(double[] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }

        // Метод для генерации массива случайных чисел
        public double[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = Math.Round(random.NextDouble() * 20 - 10, 2);
            }

            return array;
        }

        // Метод для поиска индекса минимального элемента массива
        public int MinIndex(double[] array)
        {
            double min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        // Метод для вычисления суммы элементов между первым и вторым отрицательными элементами
        public double Summa(double[] array)
        {
            int firstNegativeIndex = -1;
            int secondNegativeIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (firstNegativeIndex == -1)
                    {
                        firstNegativeIndex = i;
                    }
                    else
                    {
                        secondNegativeIndex = i;
                        break;
                    }
                }
            }

            if (firstNegativeIndex != -1 && secondNegativeIndex != -1)
            {
                double sum = 0;

                for (int i = firstNegativeIndex + 1; i < secondNegativeIndex; i++)
                {
                    sum += array[i];
                }

                return sum;
            }

            return 0;
        }




        // Метод для преобразования массива
        public void TransformArray(double[] array)
        {
            // Создание нового массива для временного хранения преобразованных данных
            double[] newArray = new double[array.Length];
            int newIndex = 0;

            // Заполнение нового массива элементами <= 1
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 1)
                {
                    newArray[newIndex++] = array[i];
                }
            }

            // Заполнение нового массива элементами > 1
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) >= 1)
                {
                    newArray[newIndex++] = array[i];
                }
            }

            // Копирование преобразованного массива в оригинальный
            Array.Copy(newArray, array, array.Length);
        }
    }
}

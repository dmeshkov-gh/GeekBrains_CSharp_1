using System;
using System.IO;

namespace MyArrayClass
{
    //    б)* Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

    class MyArray
    {
        private int[] _array;

        public int this[int index] //Индексирующее свойство
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
        public uint Lenght => (uint)_array.Length; //Возвращает длину массива

        public int Sum  // Возвращает сумму элементов массива 
        {
            get
            {
                int sum = 0;
                for(int i = 0; i < _array.Length; i++)
                {
                    sum += _array[i];
                }
                return sum;
            } 
        }
        public int[] GetArray => _array; // Свойство GetArray с помощью которого можно получить ссылку на массив.
        public int Max // Cвойство MaxCount, возвращающее максимальное значение
        {
            get
            {
                int max = _array[0];
                for (int i = 1; i < _array.Length; i++)
                    if (max < _array[i]) max = _array[i];
                return max;
            }
        }
        public int MaxCount // Cвойство MaxCount, возвращающее количество максимальных элементов
        {
            get
            {
                int max = this.Max;
                int count = 0;
                foreach(int maximum in _array) 
                    if (max == maximum) 
                        count++;

                return count;
            }
        }
        public MyArray(string filename)
        {
            string[] stringArray = File.ReadAllLines(filename);
            _array = Array.ConvertAll<string, int>(stringArray, Convert.ToInt32);
        }
        //  Конструктор, создающий массив заданной размерности
        //  и заполняющий массив числами от начального значения с заданным шагом.
        public MyArray(uint arrayLength, int initialValue, int increment)
        {
            _array = FillArray(arrayLength, initialValue, increment);
        }
        private static int[] FillArray(uint arrayLength, int initialValue, int increment)
        {
            var array = new int[arrayLength];
            array[0] = initialValue; // Задаем начальное значение массива
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] + increment;
            }
            return array;
        }
        public void Inverse() // Метод Inverse, меняющий знаки у всех элементов массива
        {
            for(int i = 0; i < _array.Length; i++)
            {
                _array[i] *= -1;
            }
        }
        public void Multi(int multiplier) // Метод Multi, умножающий каждый элемент массива на определенное число
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] *= multiplier;
            }
        }
        public void ToConsole() //Метод вывода массива на консоль
        {
            foreach (int number in _array)
                Console.Write(number + " ");
            Console.WriteLine();
        }
        public MyArray CopyTo(MyArray newArray) // Метод MyArray Copy(), возвращающий копию массива 
        {
            for(int i = 0; i< _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            return newArray;
        }
        public void Resize(uint newLength) //метод Resize(int newSize) изменяющий размер массива 
        {
            int[] newArray = new int[newLength];
            for(int i =0;i < _array.Length; i++)
                newArray[i] = _array[i];
                
            _array = newArray;
        }
        // Метод Merge объединяющий два массива в один
        public void MergeWith(MyArray myArray)
        {
            int[] newArray = new int[_array.Length + myArray.Lenght]; // Создаем новый массив
            for (int i = 0; i < _array.Length; i++) //Записываем данные из первого массива в новый
                newArray[i] = _array[i];
            for (int i = 0; i < myArray.Lenght; i++) //Записываем данные из второго массива в новый
                newArray[i + _array.Length] = myArray[i];

            _array = newArray;
        }
        public void WriteToFile(string filename)
        {
            string[] stringArray = Array.ConvertAll<int, string>(_array, Convert.ToString);
            File.WriteAllLines(filename, stringArray);
        }
    }
}

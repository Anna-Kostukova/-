// void метод ничего не возвращает (не используем return)


void FillArray(int[] collection) // метод создания массива
{
     int length = collection.Length;
     int index = 0;
       while(index < length) // пока индекс будет меньше length
          {
            collection[index] = new Random().Next(1, 10); // обратиться к collection на позицию index и 
                      // положить туда новое случайное число из диапазона 1 - 10
            index++;
         }
 }

void PrintArray(int[] col) // метод, который будет печатать массив
 {
      int count = col.Length; // количество элементов
      int position = 0; // текущая позиция
        while (position < count) // пока позиция меньше чем count
           {
             Console.WriteLine(col[position]); // будем выводить на консоль значение текущего элемента
             position++;
           }
 }

int IndexOf(int[] collection, int find) //метод, в качестве аргумента 
                                        //будет приходить массив int[] collection и какой-то элемент find
 {
       int count = collection.Length;  // определяем кол-во элементов  
       int index = 0; // начинаем с 0 индекса
       int position = -1;
        while  (index < count)
           {
            if(collection[index] == find) // если совпал с find
            {
              position = index; // то сохраняем позицию, куда положим значение нашего индекса
            }
            index++;
           }
        return position;   
 }

int[] array = new int[10]; //создай массив, в котором будет 10 элементов

 FillArray(array); // вызываем первый метод создания массива
 PrintArray(array); // вызываем второй метод печати
 Console.WriteLine();

 int pos = IndexOf(array, 8);
 Console.WriteLine(pos);

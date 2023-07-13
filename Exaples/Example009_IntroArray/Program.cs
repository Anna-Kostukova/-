// Ищем максимум из 9 чисел - функция array - через индекс числа

int Max(int arg1, int arg2, int arg3) // функция выбора из трех значений максимальное
{
    int result = arg1 ;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
            //  0  1  2  3   4    5   6  7  8
int[] array = {12,52,37,34,98775,666,73,85,229}; // определяем массив из 9 чисел

// array[0]= 12 если нужно обратиться к конкретному элементу нашего массива (нулевому элементу массива
             // присвоить значение 12)
// Console.WriteLine(array[4]) вывести на консоль число с индексом 4
 
int max = Max(
     Max(array[0], array[1], array[2]), //  по три числа сравниваем 
     Max(array[3], array[4], array[5]),
     Max(array[6], array[7], array[8])      
);

Console.WriteLine(max);


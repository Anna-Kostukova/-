// Ищем максимум из 9 чисел

int Max(int arg1, int arg2, int arg3) // функция(метод) выбора из трех значений максимальное
{
    int result = arg1 ;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 34;
int b1 = 23;
int c1 = 55555;
int a2 = 12;
int b2 = 76;
int c2 = 7757;
int a3 = 45;
int b3 = 32;
int c3 = 8;

int max1 = Max(a1, b1, c1); // результатом работы функции мах будет являться 
                            //максимальное из трех чисел (первой тройки) 
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3); // выбираем теперь мах из максимальных

Console.WriteLine(max);



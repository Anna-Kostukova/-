// Определить три точки 
// Выбрать две любых
// Найти середину
// Поставить точку
// Выбрать случайную вершину треугольника
// Соединить ее с полученной на 4 шаге точкой
// Перейти к шагу 3
// Найти Шаги 3-7 повторить 9, 28, 31, 500, 100  раз;

Console.Clear();
// Console.SetCursorPosition(10, 4);  // расположение точки на консоли
// Console.WriteLine("+");  // рисовать будем крестиком

int xa = 2;  // определить три точки
int ya = 20;
int xb = 20;
int yb = 2; 
int xc = 40;
int yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // задаем случайную вершину треугольника (5)

int count = 0; // задаем количество раз прохождения цикла (8)

while (count < 5000)
{
    int what = new Random().Next(0, 3); // 0 1 2 - случайная вершина
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    } 

    Console.SetCursorPosition(x, y); 
    Console.WriteLine("+");
    count++; // чтобы цикл не ушел в бесконечность, шаг 1
}
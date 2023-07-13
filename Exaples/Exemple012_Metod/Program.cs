// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
// — Я думаю, — сказал князь, улыбаясь, — что,
// ежели бы вас послали вместо нашего милого
// Винценгероде, вы бы взяли приступом согласие
// прусского короля. Вы так красноречивы. Вы
// дадите мне чаю?

// Вид 1 ничего не принимают, ничего не возвращают
void Method1() 
{
    Console.WriteLine("Автор...");
}
//Method1();


// Вид 2 что-то принимают, ничего не возвращают
void Method2(string msg)
{
     Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count) // выведем сообщение какое-то количество раз
{
    int i = 0;
    while (i < count) 
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4); // вывести слово Текст 4 раза
// Method21(count: 4, msg: "Новый текст");

// Вид 3 ничего не принимают, что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// Вид 4 что-то принимают и что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
       while (i < count)
       {
        result = result + text;
        i++;
       }
       return result;
}
string res = Method4(10, "qwerty ");
// Console.WriteLine(res);


//  цикл со счетчиком for 
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//        {
//         result = result + text;
//        }
//        return result;
// }
// string res = Method4(10, "qwerty ");
// Console.WriteLine(res);

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}
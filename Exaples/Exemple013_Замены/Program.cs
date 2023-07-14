// Дан текст. 
// В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.


string text  = "— Я думаю, — сказал князь, улыбаясь, — что, "   // дан текст
             + "ежели бы вас послали вместо нашего милого "
             + "Винценгероде, вы бы взяли приступом согласие "
             + "прусского короля. Вы так красноречивы. Вы "
             + "дадите мне чаю? ";

// string s = "qwerty" // если нужно обратиться к конкретному индексу слова
//             012345
// s[3] = r

string Replace(string text, char oldValue, char newValue) // входной текст, конкретный "старый" символ и 
                                                          // конкретный "новый" символ.
{
    string result = string.Empty; // новая строка - пустая
    
    int lehgth = text.Length; // длина нашего текста (кол-во элементов)
    for (int i = 0; i < lehgth; i++) // пробегаем по всей длине текста
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если i совпал со "старым" символом
                                                                 // то записываем результат с заменой
        else result = result + $"{text[i]}"; // еслии совпадений нет - запишем текущий результат
    }

    return result; // возвращаем результат
}
string newText = Replace(text, ' ', '|'); // прописываем что на что меняем
Console.WriteLine(newText);  // выводим новый текст
Console.WriteLine(); // выведем на консоль пустую строку
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, ',', '*');
Console.WriteLine(newText);


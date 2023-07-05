// Если пользователя зовут, например, Маша, нужно поприветствовать его особенно
Console.WriteLine("Введите имя пользователя: ");
string usernume = Console.ReadLine();

if(usernume.ToLower() == "маша")   //если введенное имя совпадает с Маша (ToLower - любыми буквами)
{
    Console.WriteLine("Ура, это же МАША!"); 
}
    else                   // иначе
{
    Console.Write("Привет, ");   
    Console.WriteLine(usernume);
}    

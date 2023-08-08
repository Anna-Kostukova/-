// 5! = 5 х 4 х 3 х 2 х 1
// 5! = 5 х 4!
// 4! = 4 х 3!
// 3! = 3 х 2!

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 7; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

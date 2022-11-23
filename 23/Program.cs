// Ввести N и показать таблицу кубов от 1 до N

Console.Write("Input number: ");
double N = Convert.ToDouble(Console.ReadLine());

for (double i = 1; i <= N; i++)
{
    double answer = Math.Pow(i, 3);
    Console.WriteLine($"{i} ^ 3 = {answer}");
}
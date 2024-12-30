Console.WriteLine("Введите, пожалуйста, цифру: ");
int userInput = int.Parse(Console.ReadLine());

for (int i = 0; i <= userInput; ++i)
{
    Console.WriteLine(i);
}

for (int j = userInput; j >= 0; --j)
{
    Console.WriteLine(j);
}
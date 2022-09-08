Console.WriteLine("Введите число");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
int numbertThree = 0;

if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
    number = number / 10;
    }
       numbertThree = number % 10;
       Console.WriteLine("Третья цифра заданного числа " + numbertThree);
}
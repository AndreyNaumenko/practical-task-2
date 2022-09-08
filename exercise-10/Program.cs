Console.WriteLine("Введите трехзначное число");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
int numberTwo = 0;

numberTwo = number / 10;
numberTwo = numberTwo % 10;

Console.WriteLine("Вторая цифра этого числа " + numberTwo);
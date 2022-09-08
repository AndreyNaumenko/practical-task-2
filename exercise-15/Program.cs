Console.WriteLine("Введите цифру, обозначающую день недели");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
if(number < 1)
    {
        Console.WriteLine("Цифра не соответствует дню недели");
    }
else
{
    if(number > 7)
    {
        Console.WriteLine("Цифра не соответствует дню недели");
    }
    else
    {
        if(number < 6)
        {
            Console.WriteLine("Это будний день");
        }
        else
        {
            if(number > 5)
            {
                Console.WriteLine("Это выходной день");
            }
        }
    }
}
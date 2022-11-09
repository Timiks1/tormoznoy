
int type;
while (true)
{
    Console.WriteLine("введите ваш тип покрытия:\n1 - сухой асфальт\n2 - мокрый асфльт\n3 - асфальт покрытый снегом\n4 - асфальт покрытый льдом");
    try
    {
         type = int.Parse(Console.ReadLine());
        if (type == 1 || type == 2 || type == 3 || type == 4)
        {
            break;
        }
        else
        {
            Console.WriteLine("choose right number");
        }
    }
    catch
    {
        Console.WriteLine("enter number only ");
    }

}
int speed;
while (true)
{
    Console.WriteLine("введите вашу скорость в км/ч");
    try
    {
         speed = int.Parse(Console.ReadLine());
        if (speed > 0 && speed < 300)
        {
            break;
        }
        else
        {
            Console.WriteLine("enter possible speed");
        }
    }
    catch
    {
        Console.WriteLine("enter number only ");
    }

}
double shin;
while (true)
{
    Console.WriteLine("введите разницу размера виших шин с нормой вашей машины");
    try
    {
        shin = double.Parse(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("enter number only ");
    }

}

double calculate(int type,int speed,double shin)
{
    double trueType = 0.7;
    if (type == 1)
    {
        trueType = 0.7;
    }
    else if (type == 2)
    {
        trueType = 0.4;
    }
    else if (type == 3)
    {
        trueType = 0.02;
    }
    return (speed * speed) / (254 * trueType) + shin;
}

Console.WriteLine("ваш тормозной путь = "+calculate(type,speed,shin) + " метров");
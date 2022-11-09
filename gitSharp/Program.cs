Console.WriteLine("введите ваш тип покрытия:\n1 - сухой асфальт\n2 - мокрый асфльт\n3 - асфальт покрытый снегом\n4 - асфальт покрытый льдом");
int type = int.Parse(Console.ReadLine());
Console.WriteLine("введите вашу скорость в км/ч");
int speed = int.Parse(Console.ReadLine());



double calculate(int type,int speed)
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
    return (speed * speed) / (254 * trueType);
}

Console.WriteLine("ваш тормозной путь = "+calculate(type,speed) + " метров");
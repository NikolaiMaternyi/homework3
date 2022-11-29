// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double GetLens(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double len = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return len;
}
Console.WriteLine(GetLens(3, 6, 8, 2, 1, -7));*/


// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

/*
Console.Clear();

void CheckPalindromicNumber(int number)
{
    if (number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;

        if (division1 == remainder1)
        {
            number = number / 10;
            int division2 = (number / 100) % 10;
            int remainder2 = number % 10;
            if (division2 == remainder2)
                Console.WriteLine("Да");
        }
        else
            Console.WriteLine("Нет");

    }
    else
        Console.WriteLine("Некорректное число!");
}

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);*/




//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}*/
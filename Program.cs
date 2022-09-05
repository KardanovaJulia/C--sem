//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[4]){
    Console.WriteLine($"Ваше число: {number} - ДА.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕТ.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");


//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Squares(int n)
{
    Console.WriteLine($"{n} -> ");

    int i = 1;
    while (i < n)
    {
        Console.Write($"{i * i * i}, ");
        i++;    
    }

    Console.WriteLine($"{n * n * n}. ");
}

Squares (3);
Squares (5);
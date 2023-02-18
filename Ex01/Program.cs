// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Write("Введите число: ");
string? number = Console.ReadLine();

void Number(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - не палиндром.");
}
if (number!.Length == 5)
{
  Number(number);
}
else Console.WriteLine($"Введи правильное число");



//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = coordinate("x", "a");
int y1 = coordinate("y", "a");
int z1 = coordinate("z", "a");
int x2 = coordinate("x", "b");
int y2 = coordinate("y", "b");
int z2 = coordinate("z", "b");

int coordinate(string a, string b)
{
    Console.Write($"Введите координату {a} точки {b}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Result(double x1, double x2, 
              double y1, double y2, 
              double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double LengthSegment =  Math.Round (Result(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {LengthSegment}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int index = 1;
  int length = cube.Length;
  while (index < length)
  {
    cube[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }
}

void PrintArray(int[] arr)
{
  int count = arr.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(arr[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArray(arry);



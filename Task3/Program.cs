//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Clear();
int AddInteger(int ver)
{
    
    Console.Write($"ВВедите число: ");
    ver = int.Parse(Console.ReadLine());
    return ver;
   
}
void SquareNumb(int ver)
{
    int count = 0;
    Console.Write($"{ver} -> ");
    if(ver > 0)
    {
        for (count = 1; count <= ver; count++) 
        {
            int temp = count*count*count;
            Console.Write($"{temp}, ");
        }
    }
    if(ver < 0)
    {
        for (count = -1; count >= ver; count--) 
        {
            int temp = count*count*count;
            Console.Write($"{temp}, ");
        }
    }
    else{Console.WriteLine(0);}
    
}
int square = 0;
square = AddInteger(square);
SquareNumb(square);
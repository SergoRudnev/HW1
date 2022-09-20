int CreateNamber()
{
    int namber = new Random().Next(10,100);//возвращаем случайное число
    return namber;
  
}

int a = CreateNamber();
int b = CreateNamber();
if(a>b)
{
   Console.WriteLine($"Число {a} больше числа {b}");
}
if(b>a)
{
    Console.WriteLine($"Число {b} больше числа {a}");
}


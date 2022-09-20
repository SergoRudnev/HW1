//найти наибольшее из трех чисел
int CreateNamber()
{
    int namber = new Random().Next(10,100);//возвращаем случайное число
    return namber;
  
}

int a = CreateNamber();
int b = CreateNamber();
int c = CreateNamber();
int Max = a;
if(Max<b)
{
   Max = b;
}
if(Max<c)
{
    Max = c;
}
{
    Console.WriteLine($"Число {Max} наибольшее из трех представленных {a} {b} {c} ");
}

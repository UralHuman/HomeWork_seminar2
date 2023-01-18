Console.Write("Введи число: ");

int a = Convert.ToInt32(Console.ReadLine());

string aText = Convert.ToString(a);

if (aText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + aText[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}

       
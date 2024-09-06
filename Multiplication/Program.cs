Console.Write("Skriv ditt tal du vill multiplicera : ");

string input = Console.ReadLine();

int number = int.Parse(input);



for (int i = 1; i <= 10; i++)
{
  int result = number * i;

    Console.WriteLine(number + "x" + i + "=" + result);
}


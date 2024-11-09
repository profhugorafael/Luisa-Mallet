int p = int.Parse(Console.ReadLine());
int r = int.Parse(Console.ReadLine());

// se a P for zero: C
// senao se R for zero: B
// senao: A

if (p == 0)
{
  Console.WriteLine("C");
}
else if (r == 0)
{
  Console.WriteLine("B");
}
else
{
  Console.WriteLine("A");
}
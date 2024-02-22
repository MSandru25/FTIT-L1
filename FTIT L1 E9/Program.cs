/*Scrieti un program care interschimba valoarea a doua variabile intregi.*/
Console.WriteLine("a =");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b =");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"a = {a}\nb = {b}\nDoriti sa schimbati valorile intre ele ? Y/N");
string check = Console.ReadLine();
if (String.Equals(check, "Y", StringComparison.OrdinalIgnoreCase))
{
    (a, b) = (b, a);
    Console.WriteLine($"a = {a}\nb = {b}");
}
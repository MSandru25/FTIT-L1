Console.WriteLine("x =");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z =");
int z = Convert.ToInt32(Console.ReadLine());
int[] myarr = { x, y, z };
Array.Sort(myarr);
Array.Reverse(myarr);
foreach (int i in myarr)
{
    Console.WriteLine(i);
}

/*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele
trei valori in ordine descrescatoare.*/
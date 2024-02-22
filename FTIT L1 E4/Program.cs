Console.WriteLine("Da-mi un numar");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("+");
}
else if (num < 0)
{
    Console.WriteLine("-");
}
else if (num == 0)
{
    Console.WriteLine("0");
}

/*Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”*/
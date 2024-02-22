Console.WriteLine("Da-mi un numar format din 2 cifre");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num != 0)
{
    sum += num % 10;
    num /= 10;
}
Console.WriteLine(sum);

/*While loop-ul e copiat de pe S0. Am incercat sa dau convert inputului intr-un array si apoi sa fac suma indexului
elementelor listei dar, acest limbaj, spre deosebire de python, cere metode amuzante, hazlii, umoristice chiar, de
rezolvare a problemei :)
Un beneficiu este ca functioneaza si cu un numar format din n cifre.


Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la
tastatura.
Numarul are exact 2 cifre*/
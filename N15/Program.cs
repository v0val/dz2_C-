Console.WriteLine("Введите цифру являющуюся днем недели от 1 до 7");
int d = Convert.ToInt32(Console.ReadLine());
if (d == 6 || d == 7)
{
Console.WriteLine("день является выходным");
}
else
{
if (d < 1 || d > 7)
{
Console.WriteLine("неверное значения цифры дня недели");  
}
else
{
Console.WriteLine("день не является выходным");
}

}
Console.WriteLine("Введите целое число");
string a = Console.ReadLine();
if (Convert.ToInt32(a)<100)
{
  Console.WriteLine("третьей цифры нет");  
}
else
{
Console.WriteLine(a.Substring(2, 1));
}
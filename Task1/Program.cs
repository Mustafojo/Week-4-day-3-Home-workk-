var cash = new Cashe<string>();
cash.Add("Mustafo");
cash.Add("Barotov");
cash.Add("Salom");

foreach (var item in cash.Get())
{
    System.Console.WriteLine(item);
}


cash.Remove(Console.ReadLine());

foreach (var item in cash.Get())
{
    System.Console.WriteLine(item);
}
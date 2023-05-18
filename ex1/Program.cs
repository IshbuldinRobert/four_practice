string you = "Пиплы";
void PrintMes(string name)
{
    Console.WriteLine($"Привет, {name}!");
}

int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    PrintMes("Роберт");
    PrintMes(you);

}
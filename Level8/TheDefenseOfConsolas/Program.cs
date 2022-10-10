Console.Title = "Defense of Consolas";
Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Deploy to:");

int[] squads = {row, column-1, row-1, column, row, column+1, row+1, column};

int counter = 0;

List<ConsoleColor> colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();

for (int i = 0; i <= squads.Length/2 - 1; i++) 
{
    counter++;
    Console.ForegroundColor = colors[i+1];
    Console.WriteLine($"({squads[i-1+counter]}, {squads[i+counter]})");
}
Console.Beep();
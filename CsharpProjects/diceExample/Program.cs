Random dice = new Random();
int roll = dice.Next(1, 7); // Semelhante ao Math.random do JS
int noLimitRoll = dice.Next();
Console.WriteLine(roll);
Console.WriteLine(noLimitRoll);

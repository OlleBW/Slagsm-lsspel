using System;

Random generator = new Random();

int hp1 = (100);
int hp2 = (100);
ToolBox.WriteCentered("Welcome to my fighting game! Plese write your name to start.");
string name = Console.ReadLine();
ToolBox.WriteCentered($"Hello {name}. You are fighting against player2.");
ToolBox.WriteCentered("Press Enter to punch player2.");
Console.ReadLine();
int damage = generator.Next(10, 40);
hp2 = hp2 - damage;
ToolBox.WriteCentered($"You punched player2 and did {damage} damage. player2 now has {hp2} hp left.");




Console.ReadLine();
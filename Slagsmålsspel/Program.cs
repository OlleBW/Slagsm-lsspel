using System;

Random generator = new Random();
int hp1 = (100);
int hp2 = (100);

ToolBox.WriteCentered("Welcome to my fighting game! Plese write your name to start.");
string name = Console.ReadLine();
ToolBox.WriteCentered($"Hello {name}. You are fighting against player2.");

while(hp1 > 0) {
ToolBox.WriteCentered("Press Enter to punch player2.");
Console.ReadLine();
int damage = generator.Next(10, 40);
hp2 = hp2 - damage;
ToolBox.WriteCentered($"You punched player2 and did {damage} damage. player2 now has {hp2} hp left.");
int damage2 = generator.Next(10, 40);
hp1 = hp1 - damage2;
ToolBox.WriteCentered($"player2 punched you back and did {damage2} damage. You now have {hp1} hp left.");
}

if (hp1 < 0 && hp2 > 0){
ToolBox.WriteCentered(@"_____.___.              .____                   __  ._.");
ToolBox.WriteCentered(@"\__  |   | ____  __ __  |    |    ____  _______/  |_| |");
ToolBox.WriteCentered(@" /   |   |/  _ \|  |  \ |    |   /  _ \/  ___/\   __\ |");
ToolBox.WriteCentered(@" \____   (  <_> )  |  / |    |__(  <_> )___ \  |  |  \|");
ToolBox.WriteCentered(@" / ______|\____/|____/  |_______ \____/____  > |__|  __");
ToolBox.WriteCentered(@" \/                             \/         \/        \/");
ToolBox.WriteCentered("Press Enter To Exit");
}

if (hp2 < 0 && hp1 > 0){
ToolBox.WriteCentered(@"_____.___.               __      __            ._.");
ToolBox.WriteCentered(@"\__  |   | ____  __ __  /  \    /  \____   ____| |");
ToolBox.WriteCentered(@" /   |   |/  _ \|  |  \ \   \/\/   /  _ \ /    \ |");
ToolBox.WriteCentered(@" \____   (  <_> )  |  /  \        (  <_> )   |  \|");
ToolBox.WriteCentered(@" / ______|\____/|____/    \__/\  / \____/|___|  /_");
ToolBox.WriteCentered(@" \/                            \/             \/\/");
ToolBox.WriteCentered("Press Enter To Exit");
}
if (hp2 < 0 && hp1 < 0) {
ToolBox.WriteCentered(@"___________.__      ._.");
ToolBox.WriteCentered(@"\__    ___/|__| ____| |");
ToolBox.WriteCentered(@"  |    |   |  |/ __ \ |");
ToolBox.WriteCentered(@"  |    |   |  \  ___/\|");
ToolBox.WriteCentered(@"  |____|   |__|\___  >_");
ToolBox.WriteCentered(@"                   \/\/");
ToolBox.WriteCentered("Press Enter To Exit");
}

Console.ReadLine();
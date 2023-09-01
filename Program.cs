using BashAMonster;

Gubbe martin = new Gubbe();
Monster grunt = new Monster();

HpValues();
Task.Delay(2000).Wait();
Dialogue();
Task.Delay(10000).Wait();
grunt.hp -= 50; 
HpValues();



Console.ReadLine();

void HpValues()
{
    Console.WriteLine($"Martin HP: {martin.hp}");
    Console.WriteLine($"Enemy HP: {grunt.hp}");
}

static void Dialogue()
{
    Console.WriteLine("Our character Martin, encounters a foe on his journey.");
    Console.WriteLine("Luckily, he came prepared, so he begins to attack the enemy.");
    Console.WriteLine("Martin lands a swift and clean strike.");
}
using BattelSmile;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

CreateRedTeam(out List<SmileHero> redTeam);
CreateBlueTeam(out List<SmileHero> blueTeam);

Dictionary<SmileHero, int> orderFightRedTeam = new();
Dictionary<SmileHero, int> orderFightBlueTeam = new();

Console.WriteLine("RED TEAM");
for (int i = 0; i < redTeam.Count; i++)
{
    Console.Write($"{redTeam[i].Image}\t");
}
Console.WriteLine("\nArrange the order of emoticons");

while (orderFightRedTeam.Count < 10)
{
    foreach (var item in orderFightRedTeam)
    {
        Console.Write($"{item.Value} - {item.Key.Image}\t");
    }

    Console.WriteLine("\nInput number from 0 to 9");

    var num = Console.ReadLine();

    if (!int.TryParse(num, out int value))
    {
        Console.WriteLine("A non-correct number");
        continue;
    }

    if (value < 0 || value > 9)
    {
        Console.WriteLine("A non-correct number");
        continue;
    }

    if (orderFightRedTeam.ContainsKey(redTeam[value]))
    {
        Console.WriteLine("This smile already selected");
        continue;
    }

    orderFightRedTeam.Add(redTeam[value], value);
}
Console.WriteLine("GENERATION BLUE TEAM");
Random rand = new Random();
while (orderFightBlueTeam.Count < 10)
{
    var value = rand.Next(0, 10);


    if (value < 0 || value > 9)
    {

        continue;
    }

    if (orderFightBlueTeam.ContainsKey(blueTeam[value]))
    {

        continue;
    }

    orderFightBlueTeam.Add(blueTeam[value], value);
}


Console.WriteLine("FIGHT");
Console.WriteLine("RED TEAM VS BLUE TEAM");
await Process(orderFightRedTeam, orderFightBlueTeam);



async Task Process(
    Dictionary<SmileHero, int> redTeam,
    Dictionary<SmileHero, int> blueTeam)
{
    var redOrder = redTeam
        .Select(x => x.Key)
        .ToList();

    var blueOrder = blueTeam
        .Select(x => x.Key)
        .ToList();

    var count = Math.Min(redOrder.Count, blueOrder.Count);

    foreach (var item in redTeam)
    {
        Console.Write($"{item.Value} - {item.Key.Image}\t");
    }

    Console.WriteLine("\nVS");

    foreach (var item in blueTeam)
    {
        Console.Write($"{item.Value} - {item.Key.Image}\t");
    }

    Console.WriteLine();

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Fight #{i + 1}");

        var redFighter = redOrder[i];
        var blueFighter = blueOrder[i];

        redFighter.Attack(blueFighter);

        Console.WriteLine();

        await Task.Delay(500);
    }

    int countBlue = blueTeam.Select(x => x.Key.IsLive == true).Count();
    int countRed = redTeam.Select(x => x.Key.IsLive == true).Count();

    if (countBlue > countRed)
    {
        Console.WriteLine("BLUE WIN ");
    }
    else if (countRed > countBlue)
    {
        Console.WriteLine("RED WIN");
    }
    else
    {
        Console.WriteLine("DRAW");
    }
}





void CreateBlueTeam(out List<SmileHero> blueTeam)
{

    var sunglassesFaceBlue = new SunglassesFaceSmileHero();
    sunglassesFaceBlue.smileCommand = SmileCommand.Blue;

    var frogBlue = new FrogSmileHero();
    frogBlue.smileCommand = SmileCommand.Blue;

    var rocketBlue = new RocketSmileHero();
    rocketBlue.smileCommand = SmileCommand.Blue;

    var pizzaBlue = new PizzaSmileHero();
    pizzaBlue.smileCommand = SmileCommand.Blue;

    var brainBlue = new BrainSmileHero();
    brainBlue.smileCommand = SmileCommand.Blue;

    var crossedSwordsBlue = new CrossedSwordsSmileHero();
    crossedSwordsBlue.smileCommand = SmileCommand.Blue;

    var crescentMoonBlue = new CrescentMoonSmileHero();
    crescentMoonBlue.smileCommand = SmileCommand.Blue;

    var dragonBlue = new DragonSmileHero();
    dragonBlue.smileCommand = SmileCommand.Blue;

    var gameDieBlue = new GameDieSmileHero();
    gameDieBlue.smileCommand = SmileCommand.Blue;

    var fireBlue = new FireSmileHero();
    fireBlue.smileCommand = SmileCommand.Blue;


    blueTeam = new()
    {
        sunglassesFaceBlue,
        frogBlue,
        rocketBlue,
        pizzaBlue,
        brainBlue,
        crossedSwordsBlue,
        crescentMoonBlue,
        dragonBlue,
        gameDieBlue,
        fireBlue
    };

}
void CreateRedTeam(out List<SmileHero> redTeam)
{
    var sunglassesFaceRed = new SunglassesFaceSmileHero();
    sunglassesFaceRed.smileCommand = SmileCommand.Red;

    var frogRed = new FrogSmileHero();
    frogRed.smileCommand = SmileCommand.Red;

    var rocketRed = new RocketSmileHero();
    rocketRed.smileCommand = SmileCommand.Red;

    var pizzaRed = new PizzaSmileHero();
    pizzaRed.smileCommand = SmileCommand.Red;

    var brainRed = new BrainSmileHero();
    brainRed.smileCommand = SmileCommand.Red;

    var crossedSwordsRed = new CrossedSwordsSmileHero();
    crossedSwordsRed.smileCommand = SmileCommand.Red;

    var crescentMoonRed = new CrescentMoonSmileHero();
    crescentMoonRed.smileCommand = SmileCommand.Red;

    var dragonRed = new DragonSmileHero();
    dragonRed.smileCommand = SmileCommand.Red;

    var gameDieRed = new GameDieSmileHero();
    gameDieRed.smileCommand = SmileCommand.Red;

    var fireRed = new FireSmileHero();
    fireRed.smileCommand = SmileCommand.Red;

    redTeam = new()
    {
        sunglassesFaceRed,
        frogRed,
        rocketRed,
        pizzaRed,
        brainRed,
        crossedSwordsRed,
        crescentMoonRed,
        dragonRed,
        gameDieRed,
        fireRed
    };
}
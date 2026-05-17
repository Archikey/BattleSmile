using BattelSmile;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

CreateRedTeam(out List<SmileHero> redTeam);
CreateBlueTeam(out List<SmileHero> blueTeam);






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
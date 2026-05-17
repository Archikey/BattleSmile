using System;
using System.Collections.Generic;
using System.Text;

namespace BattelSmile
{
    internal class SunglassesFaceSmileHero : SmileHero
    {
        public SunglassesFaceSmileHero()
        {
            Image = "😎";
            smileType = SmileType.SunglassesFace;
            Strong = 80;
            IsLive = true;
        }
    }

    internal class FrogSmileHero : SmileHero
    {
        public FrogSmileHero()
        {
            Image = "🐸";
            smileType = SmileType.Frog;
            Strong = 45;
            IsLive = true;
        }
    }

    internal class RocketSmileHero : SmileHero
    {
        public RocketSmileHero()
        {
            Image = "🚀";
            smileType = SmileType.Rocket;
            Strong = 95;
            IsLive = true;
        }
    }

    internal class PizzaSmileHero : SmileHero
    {
        public PizzaSmileHero()
        {
            Image = "🍕";
            smileType = SmileType.Pizza;
            Strong = 35;
            IsLive = true;
        }
    }

    internal class BrainSmileHero : SmileHero
    {
        public BrainSmileHero()
        {
            Image = "🧠";
            smileType = SmileType.Brain;
            Strong = 70;
            IsLive = true;
        }
    }

    internal class CrossedSwordsSmileHero : SmileHero
    {
        public CrossedSwordsSmileHero()
        {
            Image = "⚔️";
            smileType = SmileType.CrossedSwords;
            Strong = 90;
            IsLive = true;
        }
    }

    internal class CrescentMoonSmileHero : SmileHero
    {
        public CrescentMoonSmileHero()
        {
            Image = "🌙";
            smileType = SmileType.CrescentMoon;
            Strong = 55;
            IsLive = true;
        }
    }

    internal class DragonSmileHero : SmileHero
    {
        public DragonSmileHero()
        {
            Image = "🐉";
            smileType = SmileType.Dragon;
            Strong = 100;
            IsLive = true;
        }
    }

    internal class GameDieSmileHero : SmileHero
    {
        public GameDieSmileHero()
        {
            Image = "🎲";
            smileType = SmileType.GameDie;
            Strong = 60;
            IsLive = true;
        }
    }

    internal class FireSmileHero : SmileHero
    {
        public FireSmileHero()
        {
            Image = "🔥";
            smileType = SmileType.Fire;
            Strong = 85;
            IsLive = true;
        }
    }
}

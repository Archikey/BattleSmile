using System;
using System.Collections.Generic;
using System.Text;

namespace BattelSmile
{
    internal abstract class SmileHero
    {
        public string Image { get; set; } = string.Empty;
        protected SmileType smileType { get; set; } = SmileType.None;
        public SmileCommand smileCommand { get; set; } = SmileCommand.None;

        protected int Strong { get; set; } = 0;
        public bool IsLive { get; set; } = false;

        public void Attack(SmileHero enemy)
        {
            Console.WriteLine($"{Image} VS {enemy.Image}");

            if (Strong > enemy.Strong)
            {
                enemy.IsLive = false;
                Console.WriteLine($"{enemy.Image} DEAD");
            }
              
            else if (Strong < enemy.Strong)
            {
                IsLive = false;
                Console.WriteLine($"{Image} DEAD");
            }
            else
            {
                enemy.IsLive = false;
                IsLive = false;
                Console.WriteLine($"{Image} AND {enemy.Image} DEADS");
            }
        }
    }

    internal enum SmileCommand
    {
        None,
        Blue,
        Red
    }

    internal enum SmileType
    {
        None,
        SunglassesFace,
        Frog,
        Rocket,
        Pizza,
        Brain,
        CrossedSwords,
        CrescentMoon,
        Dragon,
        GameDie,
        Fire
    }
}

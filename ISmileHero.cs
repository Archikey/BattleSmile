using System;
using System.Collections.Generic;
using System.Text;

namespace BattelSmile
{
    internal abstract class SmileHero
    {
        protected string Image {  get; set; } = string.Empty;
        protected SmileType smileType { get; set; } = SmileType.None;
        protected SmileCommand smileCommand { get; set; } = SmileCommand.None;

        protected int Strong { get; set; } = 0;
        protected bool IsLive { get; set; } = false;

        protected void AtackSmile(SmileHero smileHero)
        {
            Console.WriteLine($"{this.Image} VS {smileHero.Image}");

            if (this.Strong > smileHero.Strong)
                smileHero.IsLive = false;
            else if (this.Strong < smileHero.Strong)
                this.IsLive = false;
            else
            {
                smileHero.IsLive = false;
                this.IsLive = false;
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

using System;

namespace Fight
{
    class Human
    {
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intel { get; set; }
        public int dex { get; set; }
        // public static int count = 0;

        public Human(string name) {
            this.name = name;
            strength = 3;
            intel = 3;
            dex = 3;
            health = 100;
        }
        public Human(string n, int str, int i, int d, int hth) {
            name = n;
            strength = str;
            intel = i;
            dex = d;
            health = hth;
        }

        public object Attack (object man){
            System.Console.WriteLine($"parameter's man object {man}, this person's health {this.health}");
            if (man is Human){
                Human target = man as Human;
                target.health -= this.strength*5;
                System.Console.WriteLine($"{this.name} attacked {target.name} and this is the target's health {target.health}.");
                return (target as Human);
            } else {
                System.Console.WriteLine("not enemy, no attack");
                return man;
            }
        }

    }
}

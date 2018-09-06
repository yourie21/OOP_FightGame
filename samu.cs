using System; using System.Collections.Generic;
namespace Fight {
    class Samu : Human {
        Random rand = new Random();
        public static int count;

        public Samu (string n):base(n) {
            health = 200;
            count++;
        }
        public Samu Strike (Human target){
            if (target.health < 50){
                target.health = 0;
            } else {
                target.health = rand.Next(50, 90); //kind of merciful, randomly changing your health to somewhere below 90 
                base.Attack(target); //hahaha, ouch
            }
            return this;
        }
        public void Count(){
            System.Console.WriteLine($"there are {count} many Samurais.");
        }
    }
}
using System; using System.Collections.Generic;
namespace Fight{
    class Wiz : Human {
        Random rand = new Random();

        public Wiz (string n) : base(n) {
            intel = 25;
            health = 50;
        }
        public Wiz Heal() {
            // health += intel * 10;
            health += rand.Next(20, 101); 
            return this;
        } 
        //Wiz is getting Ninja's method Suck to hurt a ninja (you instance)'s health by -15
        public Wiz Damage(Ninja you){
            you.Suck();
            return this;
        }
        public Wiz Fire (Human target){ //same as Fire
            target.health -= rand.Next(20, 51);
            return this;
        }
        public Wiz Fire2 (object target){
            Human sucker = target as Human;
            sucker.health -= rand.Next(20, 51);
            return this;
        }
    }
}
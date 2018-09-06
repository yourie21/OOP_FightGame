using System; using System.Collections.Generic;
namespace Fight {
    class Ninja : Human {
        Random rand = new Random();

        public Ninja(string n) : base(n) {
            dex = 175;
        }
        //this method is such a savage, haha
        public Ninja Steal(Human target) {
            if (target is Wiz){
                base.Attack(target); //Human class's Attack method
                int steal = Math.Abs(target.health/3);
                int gain = rand.Next(steal);
                target.health -= gain;
                this.health += gain;
            } else {
                System.Console.WriteLine("we're friends(samu or human), no fighting");
                return this;
            }
            return this;
        }
        public Ninja Suck (){
            this.health -= 15;
            return this;
        }

    }
}
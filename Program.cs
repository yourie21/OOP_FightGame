using System;

namespace Fight
{
    
    class Program
    {
        // public static int count;
        
        static void Main(string[] args){
            Console.WriteLine("Hello Yourie!");
            Human man1 = new Human("josh");
            Human man2 = new Human("keishi",8,8,8,5);

            // System.Console.WriteLine(man1.health);
            // man2.Attack(man1);
            // man2.Attack(5);
            // System.Console.WriteLine(man1.health);

            Wiz wiz1 = new Wiz("wiz1");
            Wiz wiz2 = new Wiz("wiz2");
            Samu sam1 = new Samu("sam1");
            Samu sam2 = new Samu("sam2");
            Ninja nin1 = new Ninja("nin1");
            Ninja nin2 = new Ninja("nin2");

            System.Console.WriteLine(wiz1.Heal().Damage(nin1).Fire(wiz2).Fire(wiz2));
            System.Console.WriteLine(wiz2.Heal().Fire(wiz1).Fire(wiz1));

            System.Console.WriteLine(sam1.Strike(nin2).Strike(sam2).Strike(wiz1));
            sam1.Count();
            System.Console.WriteLine(nin2.Steal(sam1).Steal(wiz1).Suck());
            System.Console.WriteLine(nin1.Steal(wiz1).Steal(wiz1).Steal(wiz1));
            System.Console.WriteLine(wiz1.Damage(nin1));
        }
    }
}

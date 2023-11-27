using WeaponLib;
using static System.Console;



namespace Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            WriteLine("Welcome to shooter simulator");

            Target t = new Target();
            t.setStrength();
            t.showStrength();

            IWeaponFactory factory = new ChooseWeapon();
            var item = factory.Create();

            switch (item)
            {
                case Pistol:
                    while (t.Strength > 0)
                    {
                        t.showStrength();
                        item.Shoot();
                        t.Strength -= 20;
                        count++;
                    }
                    break;
                case Rifle:
                    while (t.Strength > 0)
                    {
                        t.showStrength();
                        item.Shoot();
                        t.Strength -= 50;
                        count++;
                    }
                    break;
                case Shotgun:
                    while (t.Strength > 0)
                    {
                        t.showStrength();
                        item.Shoot();
                        t.Strength -= 80;
                        count++;
                    }
                    break;
                default: 
                    throw new Exception ("Non-existing weapon");
                    
            }
            WriteLine("The target has been defeated. Amount of shoots: " + count);
            


        }
    }
}
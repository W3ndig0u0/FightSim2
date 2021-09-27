using System;

namespace FIghtsim
{
  class Program
  {
    static void Main(string[] args)
    {
      Char heroFighter = new Char("BABABBA");
      Char enemyFighter = new Char("DADAADDA");
      Weapon enemyFighterWeapon = new Weapon("12");
      Weapon heroFighterWeapon = new Weapon("13");

      Console.WriteLine(heroFighter.name);
      Console.WriteLine(heroFighter.hp);

      Console.WriteLine(enemyFighter.name);
      Console.WriteLine(enemyFighter.hp);


      Console.WriteLine(enemyFighterWeapon.weaponName);
      Console.WriteLine(enemyFighterWeapon.strength);

      Console.WriteLine(heroFighterWeapon.weaponName);
      Console.WriteLine(heroFighterWeapon.strength);
      Console.ReadLine();
    }
  }
}

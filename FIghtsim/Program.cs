using System;

namespace FIghtsim
{
  class Program
  {
    static void Main(string[] args)
    {
      Char heroFighter = new Char("BABABBA");
      Char enemyFighter = new Char("DADAADDA");
      Weapon enemyFighterWeapon = new Weapon("DAMA");
      Weapon heroFighterWeapon = new Weapon("BAMA");

      Console.WriteLine(heroFighter.name);
      Console.WriteLine(heroFighter.hp);

      Console.WriteLine(enemyFighter.name);
      Console.WriteLine(enemyFighter.hp);


      Console.WriteLine(enemyFighterWeapon.weaponName);
      Console.WriteLine(enemyFighterWeapon.strength);

      Console.WriteLine(heroFighterWeapon.weaponName);
      Console.WriteLine(heroFighterWeapon.strength);

    }
  }
}
using System;

namespace FIghtsim
{
  public class Weapon
  {
    public string weaponName;
    public int strength = 0;
    private Random generator = new Random();

    public Weapon(string n)
    {
      weaponName = n;
      strength = generator.Next(6, 12);
    }


  }
}

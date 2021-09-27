using System;

namespace FIghtsim
{
  public class Char
  {
    public int hp = 100;
    public int strength = 0;
    private Random generator = new Random();
    public string name;

    public void Hurt(int amount)
    {
      hp -= amount;
    }

    public Char(string n)
    {
      name = n;
      strength = generator.Next(6, 12);
    }
  }
}

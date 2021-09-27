using System;

namespace FIghtsim
{
  public class Char
  {
    public int hp = 100;
    public string name;

    public void Hurt(int amount)
    {
      hp -= amount;
    }

    public Char(string n)
    {
      name = n;
    }

  }
}

using UnityEngine;
using System.Collections;

public class Bullet
{
	public Bullet(int damage)
	{
		this.damage = damage;
	}

	public Bullet(Bullet b)
	{
        damage = b.damage;
        slowMod = b.slowMod;
        poisonDot = b.poisonDot;
    }

    public int damage;
    public int slowMod;
    public int poisonDot;
    // whatever else you need
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Monster : Unit
{
    void Start()
    {
        GetComponentInChildren<SpriteAnimation>().LoadEnemyImage(gameObject.name);
    }
}


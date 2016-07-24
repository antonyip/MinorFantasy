using UnityEngine;
using System.Collections;

public class EnemyLeftRight : Enemy
{

	bool jumped = false;

	// Use this for initialization
	void Start ()
	{

	}

	// called by enemy manager
	public override void UpdateAI()
	{
		if (jumped)
		{

			int prev = eCol;

			eCol += 1;
			if (eCol > GameScript.maxCol -1)
				eCol = 0;

			GameScript.instance.blockedFloors[prev+eRow*GameScript.maxRow] = 0;

			if (GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] != 0)
			{
				eCol = prev;
			}

			GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] = eID;

			jumped = false;
		}
		else
		{
			int prev = eCol;

			eCol -= 1;
			if (eCol < 0)
				eCol = GameScript.maxCol-1;

			GameScript.instance.blockedFloors[prev+eRow*GameScript.maxRow] = 0;

			if (GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] != 0)
			{
				eCol = prev;
			}

			GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] = eID;

			jumped = true;
		}
	}
}

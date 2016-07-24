using UnityEngine;
using System.Collections;

public class EnemyUpDown : Enemy
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
			int prev = eRow;

			eRow += 1;
			if (eRow > GameScript.maxRow -1)
				eRow = 0;

			GameScript.instance.blockedFloors[eCol+prev*GameScript.maxRow] = 0;
			
			if (GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] != 0)
			{
				eRow = prev;
			}
			
			GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] = eID;

			jumped = false;
		}
		else
		{
			int prev = eRow;

			eRow -= 1;
			if (eRow < 0)
				eRow = GameScript.maxRow-1;

			GameScript.instance.blockedFloors[eCol+prev*GameScript.maxRow] = 0;
			
			if (GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] != 0)
			{
				eRow = prev;
			}
			
			GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] = eID;

			jumped = true;
		}
	}
}

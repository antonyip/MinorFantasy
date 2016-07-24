using UnityEngine;
using System.Collections;

public class EnemyCircular : Enemy
{
	int State = 0;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// called by enemy manager
	public override void UpdateAI()
	{
		if (State == 0)
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

			++State;
		}
		else if (State == 1)
		{
			int prev = eRow;

			eRow += 1;
			if (eRow > GameScript.maxRow-1)
				eRow = 0;

			GameScript.instance.blockedFloors[eCol+prev*GameScript.maxRow] = 0;
			
			if (GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] != 0)
			{
				eRow = prev;
			}
			
			GameScript.instance.blockedFloors[eCol+eRow*GameScript.maxRow] = eID;
			
			++State;
		}
		else if (State == 2)
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
			
			++State;
		}
		else if (State == 3)
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
			
			State = 0;
		}
	}
}

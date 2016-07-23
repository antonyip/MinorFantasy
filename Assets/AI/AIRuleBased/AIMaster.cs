using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIMaster : MonoBehaviour {
	
	private int NumberOfAIUnitsCreated = 0;
	private List<AIUnit> ListOfAIUnits = new List<AIUnit>();
	private List<int> UnusedUnits = new List<int>();

	public List<AIAction> ListOfAIActions { get; private set; }
	public List<AILogic> ListOfAILogic{ get; private set; }
	
	// Use this for initialization
	void Start ()
	{
		ListOfAIActions = new List<AIAction> ();
		ListOfAILogic = new List<AILogic> ();

		//// Fake enum actions
		//ListOfAIActions.Add (new ActionAddVelocity());
		//ListOfAIActions.Add (new ActionAttackTarget());
		//ListOfAIActions.Add (new ActionHealTarget());
		//ListOfAIActions.Add (new ActionMoveToTarget());
		//ListOfAIActions.Add (new ActionMoveToRandomSpot());
		//ListOfAIActions.Add (new ActionBuffAttackTarget());
		//ListOfAIActions.Add (new ActionHealSelf());

		//// Fake enum Logic
		//ListOfAILogic.Add (new LogicAlwaysTrue());
		//ListOfAILogic.Add (new LogicAlwaysFalse());
		//ListOfAILogic.Add (new LogicAlternateTrueFalse());
		//ListOfAILogic.Add (new LogicTargetNearestEnemy());
		//ListOfAILogic.Add (new LogicTargetFurthestEnemy());

		//ListOfAILogic.Add (new LogicTargetNearestFriend());
		//ListOfAILogic.Add (new LogicTargetFurthestFriend());
		//ListOfAILogic.Add (new LogicTargetRandomEnemy());
		//ListOfAILogic.Add (new LogicTargetRandomFriend());
		//ListOfAILogic.Add (new LogicTargetSelf());

		//ListOfAILogic.Add (new LogicWhenBossInAttackState());
		//ListOfAILogic.Add (new LogicWhenBossInMovingState());

		//ListOfAILogic.Add (new LogicTargetEnemyLess75());
		//ListOfAILogic.Add (new LogicTargetEnemyLess50());
		//ListOfAILogic.Add (new LogicTargetEnemyLess25());
		
		//ListOfAILogic.Add (new LogicTargetFriendLess75());
		//ListOfAILogic.Add (new LogicTargetFriendLess50());
		//ListOfAILogic.Add (new LogicTargetFriendLess25());

		//ListOfAILogic.Add (new LogicTargetSelfLess75());
		//ListOfAILogic.Add (new LogicTargetSelfLess50());
		//ListOfAILogic.Add (new LogicTargetSelfLess25());


		//ListOfAILogic.Add (new LogicTrueAfter10Seconds());
		//ListOfAILogic.Add (new LogicTrueAfter20Seconds());
		//ListOfAILogic.Add (new LogicTrueAfter30Seconds());

	}
	
	// Update is called once per frame
	void Update ()
	{
		//print ("AIMaster Update");
		UpdateAIMaster(Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.F11))
		{
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
		}

	}

	void UpdateAIMaster(float dt)
	{
		for (int i = 0; i < ListOfAIUnits.Count; i++)
		{
			if (ListOfAIUnits[i].m_inUse)
			{
				ListOfAIUnits[i].UpdateAIUnit(dt);
			}
		}

		// delete AI if needed.
		for (int i = 0; i < ListOfAIUnits.Count; i++)
		{
			if (ListOfAIUnits[i].m_ToBeDestroyed)
			{
				DeleteAIUnit(i);
			}
		}
	}

	public AIUnit CreateAIUnit(GameObject obj)
	{
		// reuse units when there is space
		AIUnit temp;
		if (UnusedUnits.Count > 0)
		{
			temp = ListOfAIUnits[UnusedUnits[UnusedUnits.Count-1]];
			UnusedUnits.Remove(UnusedUnits.Count-1);
			temp.m_GameObject = obj;
			temp.ctor();
			return temp;
		}

		++NumberOfAIUnitsCreated;
		temp = new AIUnit(NumberOfAIUnitsCreated,obj);
		ListOfAIUnits.Add (temp); // this adds by reference
		//print ("AICreated:" + NumberOfAIUnitsCreated);
		return temp;
	}

	private void DeleteAIUnit(int id)
	{
		ListOfAIUnits [id].m_inUse = false;
		UnusedUnits.Add (id);
	}
}


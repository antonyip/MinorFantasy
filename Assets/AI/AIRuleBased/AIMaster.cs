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
	}
	
	// Update is called once per frame
	void Update ()
	{
		//print ("AIMaster Update");
		//UpdateAIMaster(Time.deltaTime);
	}

	void UpdateAIMaster(float dt)
	{

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


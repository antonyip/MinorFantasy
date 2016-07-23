using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIUnit {

	public int m_ID{ get; private set;}
	public GameObject m_GameObject{ get; set;}

	public bool m_inUse = true;
	public float m_TimeSinceUnitCreated;
	private float m_CurrentTime;
	public float m_TimeToUpdate { get; set;}
	public bool m_ToBeDestroyed { get; private set;}

	List<AILogic> m_LogicToEvaulate = new List<AILogic>();
	List<AIAction> m_FunctionToCallIfTrue = new List<AIAction>();
	
	public AIUnit(int ID,GameObject obj)
	{
		m_ID = ID;
		m_GameObject = obj;
		ctor ();
	}

	public void ctor() // used in AI Master
	{
		m_inUse = true;
		m_TimeSinceUnitCreated = 0;
		m_CurrentTime = 0;
		m_TimeToUpdate = 0;
		m_ToBeDestroyed = false;
		m_LogicToEvaulate.Clear ();
		m_FunctionToCallIfTrue.Clear ();
	}

	public void UpdateAIUnit(float dt)
	{
		m_CurrentTime += dt;
		if (m_CurrentTime >= m_TimeToUpdate && m_TimeToUpdate != 0.0f)
		{
			//Debug.Log ("AIUnit Update" + m_TimeToUpdate);
			m_CurrentTime = 0.0f;
			GoThroughAILogics();
		}
	}

	public void GoThroughAILogics()
	{
		for (int i = 0; i < m_LogicToEvaulate.Count; i++)
		{
			//Debug.Log(m_LogicToEvaulate[i].m_name);
			if (m_LogicToEvaulate[i].Evaluate())
			{
				//
				m_FunctionToCallIfTrue[i].DoThis();
				return;
			}
		}
	}
	
	public void SelfDestruct()
	{
		m_ToBeDestroyed = true;
	}

	public void AttachBehaviour(AIBehaviour behaviour)
	{
		m_LogicToEvaulate.Add (behaviour.m_logic);
		m_FunctionToCallIfTrue.Add (behaviour.m_action);
	}
}

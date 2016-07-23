using UnityEngine;
using System.Collections;

public class AIBehaviour {

	public GameObject m_GameObject {get; set;}
	public AIAction m_action { get; private set;}
	public AILogic m_logic { get; private set;}

	public AIBehaviour()
	{
		m_action = null;
		m_logic = null;
	}

	public void AttachDecision(AIAction action)
	{
		m_action = action;
		//Debug.Log("action Attached");
	}

	public void AttachLogic(AILogic logic)
	{
		m_logic = logic;
		//Debug.Log("Logic Attached");
	}

	public void AttachGameObject(GameObject obj)
	{
		m_GameObject = obj;
		m_action.m_GameObject = obj;
		m_logic.m_GameObject = obj;
	}
}

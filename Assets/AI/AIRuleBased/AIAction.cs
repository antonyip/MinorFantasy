using UnityEngine;
using System.Collections;

public class AIAction {

	public GameObject m_GameObject {get; set;}
	public string m_name { get; set; }

	public AIAction()
	{
		m_name = "AIAction Name Undefined in Code";
	}

	public virtual AIAction CloneSelf()
	{
		return new AIAction();
	}

	public virtual void DoThis()
	{
		// Nothing Here.
	}

}

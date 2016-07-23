using UnityEngine;
using System.Collections;

public class AILogic {

	public GameObject m_GameObject {get; set;}
	public string m_name { get; set; }
	
	public AILogic()
	{
		m_name = "AILogic Name Undefined in Code";
	}

	public virtual AILogic CloneSelf()
	{
		return new AILogic();
	}

	public virtual bool Evaluate()
	{
		return false;
	}
}

using UnityEngine;
using System.Collections;

public class AIBase : MonoBehaviour
{
	private AIMaster refAIMaster;
	public AIUnit refAIUnit;
	// Use this for initialization
	public virtual void Start ()
	{
		refAIMaster = GameObject.Find("AIMaster").GetComponent<AIMaster>();
		refAIUnit = refAIMaster.CreateAIUnit(this.gameObject);
	}
	
}

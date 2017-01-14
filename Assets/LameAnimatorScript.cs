using UnityEngine;
using System.Collections;

public class LameAnimatorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GetComponent<Animator>().GetInteger("StateMachine") == 1)
            {
                GetComponent<Animator>().SetInteger("StateMachine", 0);
            }
            else
            {
                GetComponent<Animator>().SetInteger("StateMachine", 1);
            }
        }
	}

    public void ResetStateMachine()
    {
        GetComponent<Animator>().SetInteger("StateMachine", 0);
    }
}

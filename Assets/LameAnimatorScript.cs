using UnityEngine;
using System.Collections;

public class LameAnimatorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void LoadEnemyImageInner(string s)
    {

    }

    public void LoadEnemyAttackInner(string s)
    {
        GetComponentInChildren<Animator>().SetInteger("StateMachine", 1);
        StartCoroutine("TurnOffAttack");
    }

    IEnumerator TurnOffAttack()
    {
        yield return new WaitForSeconds(1.5f);
        GameMaster.instance.AnimationLock = false;
    }
}


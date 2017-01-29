using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class Enemy1Script : MonoBehaviour {

    public GameObject MainBody;
    public List<GameObject> SubBodys;

    public enum AnimationMode
    {
        NONE,
        IDLE,
        ATTACK,
    };

    public AnimationMode AnimMode;

    // Use this for initialization
    void Start () {
        AnimMode = AnimationMode.IDLE;
    }

    public void LoadEnemyImageInner(string s)
    {

    }

    public void LoadEnemyAttackInner(string s)
    {
        AnimMode = AnimationMode.ATTACK;
        StartCoroutine("TurnOffAttack");
    }

    IEnumerator TurnOffAttack()
    {
        yield return new WaitForSeconds(0.5f);
        AnimMode = AnimationMode.IDLE;
    }

    void FixedUpdate()
    {
        if (AnimMode == AnimationMode.IDLE)
        {
            foreach (var SubBody in SubBodys)
            {
                SubBody.transform.Rotate(0, 0, 3);
            }
        }
    }
}

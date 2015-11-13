using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour {

    int row;
    int col;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetID(int row, int col)
    {
        this.row = row;
        this.col = col;
    }

    void OnMouseDown()
    {
        Debug.Log("pos: " + row + " " + col);
    }
}

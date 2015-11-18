using UnityEngine;
using System.Collections;

public enum FloorType
{
	WHITE,
	BLACK,
	NULL,
	RED,
	BLUE,
	GREEN,
	YELLOW,
	ORANGE,
	PURPLE
}

public class FloorScript : MonoBehaviour {

    int row;
    int col;
	public SpriteRenderer Image;
	public FloorType floorType = FloorType.NULL;
	public Tower tower;

    public void SetID(int row, int col)
    {
        this.row = row;
        this.col = col;
		Setup(row,col,FloorType.WHITE);
    }

	public void Setup(int row, int col, FloorType setFloorType)
	{
		floorType = setFloorType;

		switch(floorType)
		{
		case FloorType.NULL:
			Image.gameObject.SetActive(false);
			break;
		case FloorType.BLACK:
			Image.color = Color.black;
			break;
		case FloorType.WHITE:
			Image.color = Color.white;
			break;
		case FloorType.RED:
			Image.color = Color.red;
			break;
		case FloorType.BLUE:
			Image.color = Color.blue;
			break;
		case FloorType.YELLOW:
			Image.color = Color.yellow;
			break;
		case FloorType.GREEN:
			Image.color = Color.green;
			break;
		case FloorType.ORANGE:
			Image.color = new Color(1,153f/255,0,1);
			break;
		case FloorType.PURPLE:
			Image.color = Color.magenta;
			break;
		}

	}

    void OnMouseDown()
    {
		if (!UIManager.instance.isFloorSelectorOpen)
		{
	        Debug.Log("pos: " + row + " " + col);
			UIManager.instance.isFloorSelectorOpen = true;
			FloorSelectorScript.instance.FloorClicked(this);
		}
		else
		{
			UIManager.instance.isFloorSelectorOpen = false;
			FloorSelectorScript.instance.CloseFloor();
		}

    }
}

using UnityEngine;
using System.Collections.Generic;

enum Directions
{
    None,
    North,
    NorthEast,
    NorthWest,
    South,
    SouthEast,
    SouthWest
}

public class FloorGenerator : MonoBehaviour {

    public static int[] oddCol = { 0, 1, -1, 0, 1, -1 };
    public static int[] oddRow = { 1, 1, 1, -1, 0, 0 };
    public static int[] evenCol = { 0, 1, -1, 0, 1, -1 };
    public static int[] evenRow = { 1, 0, 0, -1, -1, -1 };


    public GameObject FloorPrefab;
    public Transform FloorHolder;
    public Transform StartSpot;
    public Vector3 SizeOfHexagon;

    public WaypointPathfinder wpPathfinder;
    public GameObject WaypointPrefab;

    public List<List<GameObject>> nodeStorages;

    Vector3 SizeOfHexagonUpwards;
    Vector3 SizeOfHexagonRightWards;
    Vector3 SizeOfHexagonHalfWards;

    int sizeRightwards;
    int sizeUpwards;

    // Use this for initialization
    void Start () {
        SizeOfHexagonUpwards = new Vector3(0, SizeOfHexagon.y, SizeOfHexagon.z);
        SizeOfHexagonRightWards = new Vector3(SizeOfHexagon.x,0,0);
        SizeOfHexagonHalfWards = new Vector3(0, SizeOfHexagon.y/2f, SizeOfHexagon.z/2f);              
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    public List<Vector3> FindPath(Vector3 start, Vector3 end)
    {
        return wpPathfinder.FindPath(start, end);
    }

	FloorType LetterToFloor(char c)
	{
		FloorType returnFloorType = FloorType.NULL;
		switch (c)
		{
		case 'R':
			returnFloorType = FloorType.RED;
				break;
		case 'B':
			returnFloorType = FloorType.BLUE;
			break;
		case 'G':
			returnFloorType = FloorType.GREEN;
			break;
		case 'Y':
			returnFloorType = FloorType.YELLOW;
			break;
		case 'O':
			returnFloorType = FloorType.ORANGE;
			break;
		case 'P':
			returnFloorType = FloorType.PURPLE;
			break;
		case 'W':
			returnFloorType = FloorType.WHITE;
			break;
		case 'N':
			returnFloorType = FloorType.NULL;
			break;
		case 'S':
			returnFloorType = FloorType.BLACK;
			break;
		case 'E':
			returnFloorType = FloorType.BLACK;
			break;
		default:
			Debug.LogError("Invalid Type");
			break;
		}
		return returnFloorType;
	}

    public void GenerateFloor(int Rightwards, int Upwards, string floorData)
    {
        if (Rightwards < 0)
            return;
        if (Upwards < 0)
            return;

        sizeRightwards = Rightwards;
        sizeUpwards = Upwards;

        //Set boundary limits
        Vector3 startBoundary = StartSpot.position;
        startBoundary.x -= SizeOfHexagonHalfWards.x;
        Vector3 endBoundary = StartSpot.position;
        endBoundary.y += SizeOfHexagonUpwards.y * Upwards;
        endBoundary.x += SizeOfHexagonRightWards.x * Rightwards - (Rightwards%2 * SizeOfHexagonHalfWards.x);

        // counts from bottom left upwards.
        // going right is a col
        // going up is a row
        // generate the rows and cols and the waypoint positions

        nodeStorages = new List<List<GameObject>>();
		int counter = 0;
        for (int col = 0; col < Rightwards; ++col)
        {
            nodeStorages.Add(new List<GameObject>());
            for (int row = 0; row < Upwards; ++row)
            {
                float rowf = row;
                float colf = col;
                bool oddRow = col % 2 == 0;
                GameObject go = Instantiate(FloorPrefab, StartSpot.position + SizeOfHexagonUpwards * rowf + SizeOfHexagonRightWards * colf + (oddRow ? Vector3.zero : SizeOfHexagonHalfWards),Quaternion.identity) as GameObject;

                go.GetComponent<FloorScript>().Setup(row, col,LetterToFloor(floorData[counter]));
				go.transform.SetParent(FloorHolder);

                GameObject wp = Instantiate(WaypointPrefab, StartSpot.position + SizeOfHexagonUpwards * rowf + SizeOfHexagonRightWards * colf + (oddRow ? Vector3.zero : SizeOfHexagonHalfWards), Quaternion.identity) as GameObject;
                wp.transform.SetParent(wpPathfinder.transform);
                wp.GetComponent<WaypointNode>().position = wp.transform.position + new Vector3(0,0,1);
                wp.GetComponent<WaypointNode>().ID = row + col * sizeRightwards;
				wp.GetComponent<WaypointNode>().isActive = false;
				if (LetterToFloor(floorData[counter]) != FloorType.NULL)
                	wp.GetComponent<WaypointNode>().isActive = true;
                nodeStorages[col].Add(wp);

				if ((floorData[counter]) == 'S')
					GameManager.instance.SetStart(wp.transform.position + new Vector3(0,0,1));

				if ((floorData[counter]) == 'E')
					GameManager.instance.SetEnd(wp.transform.position + new Vector3(0,0,1));
				++counter;
            }
        }

        // link the waypoint positions

        for (int col = 0; col < nodeStorages.Count; ++col)
        {
            for (int row = 0; row < nodeStorages[0].Count; ++row)
            {
                AddNeighboursFor(col, row);  
            }
        }

        //Zooming boundaries
        float maxZoom = (endBoundary.x - startBoundary.x) * 1.2f;
        float minZoom = (SizeOfHexagonRightWards.x * 3) * 1.2f;
        GameManager.instance.setBoundary(startBoundary, endBoundary, minZoom, maxZoom);
        wpPathfinder.Start();
		GameManager.instance.GeneratePath();
    }

    private void AddNeighboursFor(int col, int row)
    {
		if (!nodeStorages[col][row].GetComponent<WaypointNode>().isActive)
			return;
        // if even

        if (col%2 == 0)
        {
            for (int i = 0; i < 6; i++)
            {
                int colEdit = col + evenCol[i];
                int rowEdit = row + evenRow[i];
				if (checkInRange(colEdit, rowEdit) && nodeStorages[colEdit][rowEdit].GetComponent<WaypointNode>().isActive)
                    nodeStorages[col][row].GetComponent<WaypointNode>().neighbors.Add(nodeStorages[colEdit][rowEdit].GetComponent<WaypointNode>());
            }
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                int colEdit = col + oddCol[i];
                int rowEdit = row + oddRow[i];
				if (checkInRange(colEdit, rowEdit) && nodeStorages[colEdit][rowEdit].GetComponent<WaypointNode>().isActive)
                    nodeStorages[col][row].GetComponent<WaypointNode>().neighbors.Add(nodeStorages[colEdit][rowEdit].GetComponent<WaypointNode>());
            }
        }
        
    }

    bool checkInRange(int col, int row)
    {
        if (col < 0)
            return false;
        if (row < 0)
            return false;
        if (col >= sizeRightwards)
            return false;
        if (row >= sizeUpwards)
            return false;

        return true;
    }
}

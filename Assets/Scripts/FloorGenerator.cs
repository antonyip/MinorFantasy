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

        GenerateFloor(8, 18);

        
        
    }
	
	// Update is called once per frame
	void Update () {
       

    }

    public List<Vector3> FindPath(Vector3 start, Vector3 end)
    {
        return wpPathfinder.FindPath(start, end);
    }

    void GenerateFloor(int Rightwards, int Upwards)
    {
        if (Rightwards < 0)
            return;
        if (Upwards < 0)
            return;

        sizeRightwards = Rightwards;
        sizeUpwards = Upwards;

        // counts from bottom left upwards.
        // going right is a col
        // going up is a row
        // generate the rows and cols and the waypoint positions

        nodeStorages = new List<List<GameObject>>();

        for (int col = 0; col < Rightwards; ++col)
        {
            nodeStorages.Add(new List<GameObject>());
            for (int row = 0; row < Upwards; ++row)
            {
                float rowf = row;
                float colf = col;
                bool oddRow = col % 2 == 0;
                GameObject go = Instantiate(FloorPrefab, StartSpot.position + SizeOfHexagonUpwards * rowf + SizeOfHexagonRightWards * colf + (oddRow ? Vector3.zero : SizeOfHexagonHalfWards),Quaternion.identity) as GameObject;
                go.GetComponent<FloorScript>().SetID(row, col);
                go.transform.SetParent(FloorHolder);

                GameObject wp = Instantiate(WaypointPrefab, StartSpot.position + SizeOfHexagonUpwards * rowf + SizeOfHexagonRightWards * colf + (oddRow ? Vector3.zero : SizeOfHexagonHalfWards), Quaternion.identity) as GameObject;
                wp.transform.SetParent(wpPathfinder.transform);
                wp.GetComponent<WaypointNode>().position = wp.transform.position + new Vector3(0,0,1);
                wp.GetComponent<WaypointNode>().ID = row + col * sizeRightwards;
                wp.GetComponent<WaypointNode>().isActive = true;
                nodeStorages[col].Add(wp);
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

        wpPathfinder.Start();
		GameManager.instance.GeneratePath();
    }

    private void AddNeighboursFor(int col, int row)
    {
        // if even
        if (col%2 == 0)
        {
            for (int i = 0; i < 6; i++)
            {
                int colEdit = col + evenCol[i];
                int rowEdit = row + evenRow[i];
                if (checkInRange(colEdit, rowEdit))
                    nodeStorages[col][row].GetComponent<WaypointNode>().neighbors.Add(nodeStorages[colEdit][rowEdit].GetComponent<WaypointNode>());
            }
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                int colEdit = col + oddCol[i];
                int rowEdit = row + oddRow[i];
                if (checkInRange(colEdit, rowEdit))
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

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour {

    int ID = -1;
    int IndexInDatabase = -1;
    int Amount = 0;

    public Image sprite;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Setup(int id, int indexInDatabase, int amount)
    {
        ID = id;
        IndexInDatabase = indexInDatabase;
        Amount = amount;

        string spriteName = AntTool.CraftingMatsData.instance.Rows.Find(x => x._ID == indexInDatabase)._Sprite;
        sprite.sprite = Resources.Load<Sprite>("Items/" + spriteName);
        sprite.SetNativeSize();
    }
}

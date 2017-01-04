using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour {

	public static Director instance;
	public GameObject ManagersPrefab;
	public GameObject Managers;

	void Awake()
	{
		if (instance == null)
		{
            Screen.SetResolution(450, 800, false);
			instance = this;
			Managers = Instantiate(ManagersPrefab);
            Managers.SetActive(true);
			Managers.name = "Managers";
			Managers.transform.SetParent(this.transform);
			Managers.transform.localPosition = Vector3.zero;
			Managers.transform.localScale = Vector3.one;

		}
		else
		{
			Destroy(gameObject);
		}
	}
	// Use this for initialization
	void Start ()
	{
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

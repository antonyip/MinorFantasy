using UnityEngine;
using System.Collections.Generic;

public class SelectChoicesScript : MonoBehaviour {

    public static SelectChoicesScript instance;

    public GameObject ButtonSkillPrefab;

    public Transform ButtonContainers;

    // Use this for initialization
    void Awake () {
        instance = this;
    }
	
    void DestroyExisting()
    {
        int childCount = ButtonContainers.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Destroy(ButtonContainers.GetChild(i).gameObject);
        }
    }

    public void Setup(Unit u)
    {
        DestroyExisting();

        List<int> skills = u.character.playerStats.AvailableSkills();
        for (int i = 0; i < skills.Count; i++)
        {
            GameObject go = Instantiate(ButtonSkillPrefab) as GameObject;
            go.transform.SetParent(ButtonContainers);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            var skill = AntTool.SkillData.instance.Rows.Find(x => x._ID == skills[i]);
            go.GetComponent<SkillTargetButtonScript>().SetupSkill(skill, i);
        }
    }

    public void SetupTarget(List<string> selectableUnits)
    {
        DestroyExisting();

        for (int i = 0; i < selectableUnits.Count; i++)
        {
            GameObject go = Instantiate(ButtonSkillPrefab) as GameObject;
            go.transform.SetParent(ButtonContainers);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            go.GetComponent<SkillTargetButtonScript>().SetupTarget(selectableUnits[i], i);
        }
    }
}

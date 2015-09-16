using UnityEngine;
using System.Collections;

public class eLevelBar : MonoBehaviour {
	public GameObject fill;
	public audBtn audBtn;
	public int curLvl;
	
	void Start()
	{
		audBtn = GameObject.Find("audBtn").GetComponent<audBtn>();
	}
	
	void Update () 
	{
		//increases the green fill bars length based on current genreBtn value
		curLvl = audBtn.e1;
		fill.transform.localScale = new Vector3(curLvl * .01f, 1, 1);
		
	}
}

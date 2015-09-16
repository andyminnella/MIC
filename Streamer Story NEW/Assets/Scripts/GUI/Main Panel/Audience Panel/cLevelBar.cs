using UnityEngine;
using System.Collections;

public class cLevelBar : MonoBehaviour {
	public GameObject fill;
	public audBtn audBtn;
	public int curLvl;
	
	void Start()
	{

	}
	
	void Update () 
	{
		//increases the green fill bars length based on current genreBtn value
		curLvl = audBtn.c1;
		fill.transform.localScale = new Vector3(curLvl * .01f, 1, 1);
		
	}
}

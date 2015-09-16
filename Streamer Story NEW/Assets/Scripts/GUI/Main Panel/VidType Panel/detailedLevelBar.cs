using UnityEngine;
using System.Collections;

public class detailedLevelBar : MonoBehaviour {
	public GameObject fill;
	public vidTypeBtn vidBtn;
	public int curLvl;


	void Start()
	{

	}
	
	void Update () 
	{
		//increases the green fill bars length based on current genreBtn value
		curLvl = vidBtn.det1;
		fill.transform.localScale = new Vector3(curLvl * .01f, 1, 1);
		
	}
}

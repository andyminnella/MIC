﻿using UnityEngine;
using System.Collections;

public class rushLevelBar : MonoBehaviour {
	public GameObject fill;
	public vidTypeBtn vidBtn;
	public int curLvl;
	
	void Start()
	{
	}
	
	void Update () 
	{
		//increases the green fill bars length based on current genreBtn value
		curLvl = vidBtn.rush1;
		fill.transform.localScale = new Vector3(curLvl * .01f, 1, 1);
		
	}
}

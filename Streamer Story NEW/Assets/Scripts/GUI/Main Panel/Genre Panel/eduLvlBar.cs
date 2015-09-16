using UnityEngine;
using System.Collections;

public class eduLvlBar : MonoBehaviour {
	public GameObject fill;
	public genreBtn genreBtn;
	public int curLvl;
	
	void Start()
	{
		genreBtn = GameObject.Find("GenreBtn").GetComponent<genreBtn>();
	}
	
	void Update () 
	{
		//increases the green fill bars length based on current genreBtn value
		curLvl = genreBtn.g4;
		fill.transform.localScale = new Vector3(curLvl * .01f, 1, 1);
		
	}
}

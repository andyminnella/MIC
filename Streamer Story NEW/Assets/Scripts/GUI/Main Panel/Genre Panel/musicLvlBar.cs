using UnityEngine;
using System.Collections;

public class musicLvlBar : MonoBehaviour {

	public GameObject fill;
	public genreBtn genreBtn;
	public int curLvl;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//increases the green fill bars length based on current genreBtn value
		curLvl = genreBtn.g1;
		fill.transform.localScale = new Vector3(curLvl * .01f, 1, 1);
	}
}

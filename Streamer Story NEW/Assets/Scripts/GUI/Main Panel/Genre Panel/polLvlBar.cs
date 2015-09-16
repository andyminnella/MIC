using UnityEngine;
using System.Collections;

public class polLvlBar : MonoBehaviour {
	public GameObject fill;
	public genreBtn genreBtn;
	public int curLvl;
	// Use this for initialization
	void Start () {
		genreBtn = GameObject.Find("GenreBtn").GetComponent<genreBtn>();

	}
	
	// Update is called once per frame
	void Update () {
		curLvl = genreBtn.g3;
		fill.transform.localScale = new Vector3(curLvl * .01f, 1, 1);
	}
}

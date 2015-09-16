using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BG_Scrolling : MonoBehaviour {
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, Time.time * speed / 2);

		GetComponent<Image>().material.mainTextureOffset = offset;
	}
}

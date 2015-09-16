using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class moneyTxt : MonoBehaviour {

	private Text text;
	void Start()
	{
		text = GetComponent<Text>();
	}
	// Update is called once per frame
	void Update () {
		text.text = "$" + MasterGameObject.money;
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changeBtnColor : MonoBehaviour {
	private Image self;

	public bool hover;
	// Use this for initialization
	void Start () {
		self = GetComponent<Image>();
	}
	
	public void TrigEnter()
	{
		hover = true;
		Debug.Log("Made it in and true + " + hover);
	}

	public void TrigClose()
	{
		hover = false;
		Debug.Log("Made it out and false + " + hover);

	}


}

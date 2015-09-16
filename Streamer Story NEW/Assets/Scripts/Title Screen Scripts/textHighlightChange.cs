using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textHighlightChange : MonoBehaviour {
	private Text txt;

	//HL1 == highlighted yellowish menu color
	//r1 == regular default white/grayish text color
	private Color hl1;
	private Color r1;


	// Use this for initialization
	void Start () {
		txt = GetComponentInChildren<Text>();

		hl1 = new Color(.60f, .48f, .00f); 
		r1 =  new Color(.89f,.89f,.89f); 

	}
	
	public void ChangeColor()
	{
		txt.color = hl1;
	}

	public void StopChangeColor()
	{
		txt.color = r1;
	}
}

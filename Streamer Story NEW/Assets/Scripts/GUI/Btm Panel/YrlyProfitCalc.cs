using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YrlyProfitCalc : MonoBehaviour {
	private Text profitTxt;
	public TimeTxt timeObj;
	public float profitValue;
	private int i;
	// Use this for initialization
	void Start () {
		profitTxt = GetComponent<Text>();
		profitValue = 0;
		i = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (timeObj.yearTime > i)
		{
			profitValue = 0;
			i++;
		}
		profitValue = MasterGameObject.money - 1000;
		profitTxt.text = "Yr. Profit:$" + profitValue;
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeEstimate : MonoBehaviour {

	public audBtn audObj;
	public genreBtn genObj;
	public vidTypeBtn vidObj;

	private Text timeTxt;
	public  bool runOnce;

	public float value;
	public float a;
	public float b;
	public float c;

	public float savedTime;
	// Use this for initialization
	void Start () {
		timeTxt = GetComponent<Text>();
		runOnce = true;

		timeTxt.text = "Time Estimate: N/A";
	}
	
	// Update is called once per frame
	void Update () {
		if (genObj.genreSel > 0 && audObj.audSel > 0 && vidObj.vidTypeSel > 0 && runOnce)
		{
			timeTxt.text = "Time Estimate: " + Mathf.RoundToInt(timeCheck()) + "~ days";
			runOnce = false;
			savedTime =  Mathf.RoundToInt(timeCheck());
		} 


	}

	public float timeCheck()
	{
		//The "grab" variable takes the selected genre and checks it current level (fast/medium/slow) 
		//then applies it to the calculation
		switch (genObj.genGrab)
		{
		case 0:
			a = 4;
			break;
		case 1:
			a = 3;

			break;
		case 2:
			a = 2;

			break;
		case 3:
			a = 1;

			break;
		}

		switch (audObj.audGrab)
		{
		case 0:
			b = 4;
			break;
		case 1:
			b = 3;

			break;
		case 2:
			b = 2;

			break;
		case 3:
			b = 1;

			break;
		}

		switch ( vidObj.vidTypeSel)
		{
		case 1:
			//Rush
			switch (vidObj.vidGrab)
			{
			case 0:
				c = 0.7f;
				break;
			case 1:
				c = 0.6f;
				break;
			case 2:
				c = 0.5f;
				break;
			case 3:
				c = 0.4f;
				break;
			}
			break;
		case 2:
			//Regular
			switch (vidObj.vidGrab)
			{
			case 0:
				c = 1f;
				break;
			case 1:
				c = 0.9f;
				break;
			case 2:
				c = 0.8f;
				break;
			case 3:
				c = 0.7f;
				break;
			}
			break;
		case 3:
			//Detailed
			switch (vidObj.vidGrab)
			{
			case 0:
				c = 1.5f;
				break;
			case 1:
				c = 1.4f;
				break;
			case 2:
				c = 1.3f;
				break;
			case 3:
				c = 1.2f;
				break;
			}
			break;
		}
		value = a + b * c;
		return value;
	}

	public void switchRun()
	{
		runOnce = true;
	}
}

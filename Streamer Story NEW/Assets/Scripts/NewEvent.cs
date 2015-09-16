using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewEvent : MonoBehaviour {

	public GameObject masterGameObj;
	public GameObject eventPanel;
	public TimeTxt timeObj;
	public Text eventPanelBodyText;
	public Text titleTxt;
	public Text progTxt;

	public bool creatingVid;
	public int finVidTime;
	public float testTime;
	public bool testProgBool;

	public int oldMonth;
	public int newMonth;

	public string titleOfVid;
	 void Start()
	{
		masterGameObj = GameObject.Find("MasterGameObject");

		//sets month time equal to timeTxt monthtime
		oldMonth = timeObj.monthTime;

		//checks if the game is brand new and displays welcome event
		if (timeObj.weekTime == 1 && timeObj.monthTime == 1 && timeObj.yearTime == 1)
		{
		Create("Welcome!" , "You have just set out into the world of STREAMING! Good luck and I hope you prove mom" +
			" and dad wrong!");
		}
	}

	public void Create(string title, string bodytext)
	{
		titleTxt.text = title;
		eventPanelBodyText.text = bodytext;
		eventPanel.SetActive(true);
		timeObj.paused = true;
	}

	//takes in a int to determine how long before "finish video" panel shows with stats and outcome
	public void FinishVid(int timeAmt)
	{
		int i;
		int finTime;
		i = timeAmt * 6 + Mathf.RoundToInt(timeObj.timer);
		Debug.Log("Current time is: " + Mathf.RoundToInt(timeObj.timer));
		Debug.Log("I want to finish at: " + i);
		finTime = i;
		VidMakingProc(finTime);

	}

	public void VidMakingProc(int finTime)
	{
		finVidTime = finTime;
		creatingVid = true;
		testTime = timeObj.timer;
	}



	void Update()
	{
		//new month checker
		newMonth = timeObj.monthTime;

		float lerpValue = Mathf.Lerp (0, 100, (Time.time - testTime) * finVidTime * 0.01f);

		//fix this function make progress work correctly
		if (creatingVid && eventPanel.activeSelf == false)
		{
			progTxt.text = "Current Progress: " + lerpValue + "%";
		}
		else progTxt.text = "Current Progress: N/A"; 

		if (Mathf.RoundToInt(timeObj.timer) >= finVidTime && creatingVid)
		{
			Create("Finished Video!", "You have successfully finished "  + titleOfVid +  "! You earned 250!");
			creatingVid = false;
			MasterGameObject.money += 250;
		}

		if (newMonth > oldMonth)
		{


			Create("Rent is due", "This is just a test for further events and -350 money");
			MasterGameObject.money -=350;

			oldMonth = newMonth;

		}
	}

	public void ContinueEvent()

	{
		timeObj.paused = false;
	}


}

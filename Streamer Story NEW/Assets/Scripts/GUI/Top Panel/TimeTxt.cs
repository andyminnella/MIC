using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeTxt : MonoBehaviour {

	private Text timeTxt;
	private Text currentDateTxt;
	public float timer;
	private int count;
	public int weekTime;
	public int monthTime;
	public int yearTime;
	//run once variable
	public bool runOnce;
	//when time bar fills up this is set to true
	public bool filled;

	public bool paused;

	//game object sprites that make up the time bar
	public GameObject load1;
	public GameObject load2;
	public GameObject load3;
	public GameObject load4;
	public GameObject load5;
	public GameObject load6;
	public GameObject load7;
	public GameObject load8;
	public GameObject load9;
	public GameObject load10;
	// Use this for initialization
	void Start () {
		timeTxt = GetComponent<Text>();
		currentDateTxt = GameObject.Find("CurrentDateTxt").GetComponent<Text>();
		runOnce = false;
		count = 0;
		weekTime = 1;
		monthTime = 1;
		yearTime = 1;
		paused = false;

	}
	
	// Update is called once per frame
	void Update () {
		//creates a timer function that runs on the time
		if (!paused)
		{
		timer += Time.deltaTime;
		}
		timeTxt.text = timer.ToString("F2"); 
		//prints on top panel the current date
		currentDateTxt.text = "Week: " + weekTime + " Month: " + monthTime + " Year: " + yearTime;

		//edit this to control timerate
		if(Mathf.RoundToInt(timer) % 6 == 0 && runOnce == false && timer > 5 && !paused)
		{
			StartCoroutine(TimeWait());
			runOnce = true;
		}
	}

	public void PauseTest()
	{
		if (!paused)
		{
		paused = true;
		}

		else paused = false;
	}

	//coroutine to stop from spamming runOnce check
	IEnumerator TimeWait() 
	{
		yield return new WaitForSeconds(1);
        
        
		count++;
		enableBar(count);
		runOnce = false;

		//when the progress bar hits 10, run to enable bar function and remove all the progress and reset to 0
		if (count == 10)
		{
			Debug.Log("I am filled");
			count = 0;
			enableBar(count);

			if (weekTime <= 4)
			{
				weekTime+=1;

			}

			if (weekTime == 5)
			{
				monthTime +=1;
				weekTime = 1;
			}

			if (monthTime == 12)
			{
				monthTime = 1;
				yearTime +=1;
			}
		}
		StopCoroutine(TimeWait());



	}

	public void enableBar(int count)
	{
		switch (count)
		{
		case 0:
			load1.SetActive(false);
			load2.SetActive(false);
			load3.SetActive(false);
			load4.SetActive(false);
			load5.SetActive(false);
			load6.SetActive(false);
			load7.SetActive(false);
			load8.SetActive(false);
			load9.SetActive(false);
			load10.SetActive(false);
			break;

		case 1:
			load1.SetActive(true);

			break;
		case 2:
			load2.SetActive(true);
			break;
		case 3:
			load3.SetActive(true);
			break;
		case 4:
			load4.SetActive(true);
			break;
		case 5:
			load5.SetActive(true);
			break;
		case 6:
			load6.SetActive(true);
			break;
		case 7:
			load7.SetActive(true);
			break;
		case 8:
			load8.SetActive(true);
			break;
		case 9:
			load9.SetActive(true);
			break;
		case 10:
			load10.SetActive(true);
			filled = true;
			break;
		}


	}

}

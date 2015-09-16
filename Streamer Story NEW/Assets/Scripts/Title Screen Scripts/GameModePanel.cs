using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameModePanel : MonoBehaviour {

	//variables for displaying text at bottom of game setup panel
	public Text descTxt;
	public int descIndex;

	//variables to setup game mode options
	//0 = normal game mode, 1 = custom game mode
	private int gameMode;
	public GameObject check1;
	public GameObject check2;
	public Text userNameInput;
	public string userName;

	// Use this for initialization
	void Start () {
		descIndex = 0;
	}
	
	void descCheck()
	{
		switch (descIndex)
		{
		case 0:
			descTxt.text = "Select an option for further details...";
			break;

		case 1:
			descTxt.text = "The default game mode. Staff and opponent names will all be randomly generated. Good luck!";
			break;

		case 2:
			descTxt.text = "Custom mode. In this mode you can freely edit and change the names of potential staff and opponents" +
				" + change additional settings. \n**Recommended for experienced users**";
			break;

		case 3:
			descTxt.text = "Select your username! This will be used on all videos and what you will be referred to by others whilst playing.";
			break;

		case 4:
			descTxt.text = "Select a save slot.";
			break;
		}
	}

	public void descIndex_Zero()
	{
		descIndex = 0;
		descCheck();
	}

	public void descIndex_One()
	{
		descIndex = 1;
		descCheck();
	}

	public void descIndex_Two()
	{
		descIndex = 2;
		descCheck();
	}

	public void descIndex_Three()
	{
		descIndex = 3;
		descCheck();
	}

	public void descIndex_Four()
	{
		descIndex = 4;
		descCheck();
	}

	// Determines whether custom or normal mode was chosen, and runs appropriate setup
	public void normalSelect()
	{
		gameMode = 0;
		check1.SetActive(true);
		check2.SetActive(false);
	}

	public void customSelect()
	{
		gameMode = 1;
		check1.SetActive(false);
		check2.SetActive(true);
	}

	public void continueCheck()
	{
		switch (gameMode)
		{
			//normal mode 
		case 0:
			userName = userNameInput.text;

			if (userName == "")
			{
				Debug.Log("Please enter a name before continuing");
			}
			GameObject.Find("Game Mode Panel").SetActive(false);
			Debug.Log("your username is: " + userName);
			break;

			//custom mode
		case 1:
			break;
		}
	}
}

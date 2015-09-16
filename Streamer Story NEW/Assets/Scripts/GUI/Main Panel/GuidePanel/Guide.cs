using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Guide : MonoBehaviour {

	//variables for the next and prev btn
	public int count;


	private Text bodyText;
	// Use this for initialization
	void Start () {
		count = 0;
		bodyText = GameObject.Find("GuideTxt").GetComponent<Text>();
	}

	void TextCheck()
	{
		switch(count)
		{
		case 0: bodyText.text = "Welcome to Streamer Story! \n \n From humble beginnings help grow your channel from a small " +
			"part-time hobby to a full fledged career! Choose your audience, videos, and message wisely!";

			break;
		case 1: bodyText.text = "Upload Page Info \n \n This page refers to all data about the upload page in the game";
			break;
		case 2: bodyText.text = "Staff Page Info \n \n This page refers to all data about the staff page in the game";
			break;
		case 3: bodyText.text = "Business Page Info \n \n This page refers to all data about the upload page in the game";
			break;
		case 4: bodyText.text = "Tips and tricks + hints";
			break;
		case 5: bodyText.text = "Authors note and close";
			break;
		}
	}

	public	void Next()
	{

		if (count <= 5)
		{
			count++;
			TextCheck();
		}

		if (count == 6)
		{
			count = 0;
			TextCheck();
		}
	
	}

	public	void Prev()
	{
		if(count >= 0)
		{
			count--;
			TextCheck();
		}

		if (count == -1)
		{
			count = 5;
			TextCheck();
		}
	}
}

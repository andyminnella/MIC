using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class genreBtn : MonoBehaviour {

	public GameObject genrePanel;

	private Text GenreTxt;
	
	public bool isClicked;

	public int genreSel;

	//musTxt refers to the time estimate
	public Text musTxt;
	//musLvl refers to the overall level (1,2,3)max
	public int musLvl;
	//g prefix refers to individual bar level for each type
	public int g1;
	//max refers to "Max Img" showing over the level bar if at max level
	public GameObject g1Max;
	
	public Text vgTxt;
	public int vgLvl;
	public int g2;
	public GameObject g2Max;

	public Text polTxt;
	public int polLvl;
	public int g3;
	public GameObject g3Max;

	public Text eduTxt;
	public int eduLvl;
	public int g4;
	public GameObject g4Max;

	public Text artTxt;
	public int artLvl;
	public int g5;
	public GameObject g5Max;

	public Text nonTxt;
	public int nonLvl;
	public int g6;
	public GameObject g6Max;

	public int genGrab;

	// Use this for initialization
	void Start () {
		GenreTxt = GetComponentInChildren<Text>();
		genreSel = 0;

		//Set all the max level images to off at start of game
		g1Max.SetActive(false);
		g2Max.SetActive(false);
		g3Max.SetActive(false);
		g4Max.SetActive(false);
		g5Max.SetActive(false);
		g6Max.SetActive(false);
	}


	// Update is called once per frame
	void Update () {

		if (g1 >= 100 && musLvl < 3)
		{
			musLvl++;
			int hold;
			hold = g1;
			hold -= 100;
			Debug.Log(hold);
			g1 = 0;
			g1 += hold;

		}

		if (g2 >= 100 && vgLvl < 3)
		{
			vgLvl++;
			int hold;
			hold = g2;
			hold -= 100;
			Debug.Log(hold);
			g2 = 0;
			g2 += hold;
		}

		if (g3 >= 100 && polLvl < 3)
		{
			polLvl++;
			int hold;
			hold = g3;
			hold -= 100;
			Debug.Log(hold);
			g3 = 0;
			g3 += hold;
		}

		if (g4 >= 100 && eduLvl < 3)
		{
			eduLvl++;
			int hold;
			hold = g4;
			hold -= 100;
			Debug.Log(hold);
			g4 = 0;
			g4 += hold;
		}

		if (g5 >= 100 && artLvl < 3)
		{
			artLvl++;
			int hold;
			hold = g5;
			hold -= 100;
			Debug.Log(hold);
			g5 = 0;
			g5 += hold;
		}

		if (g6 >= 100 && nonLvl < 3)
		{
			nonLvl++;
			int hold;
			hold = g6;
			hold -= 100;
			Debug.Log(hold);
			g6 = 0;
			g6 += hold;
		}



		switch (genreSel)
		{
		case 0:
			GenreTxt.text = "Select a genre...";
			break;

		case 1:
			GenreTxt.text = "Music";
			genGrab = musLvl;
				break;

		case 2:
			GenreTxt.text = "Video Games";
			genGrab = vgLvl;
				break;

		case 3:
			GenreTxt.text = "Politics";
			genGrab = polLvl;
				break;

		case 4:
			GenreTxt.text = "Education";
			genGrab = eduLvl;
				break;

		case 5:
			GenreTxt.text = "Art";
			genGrab = artLvl;
				break;

		case 6:
			GenreTxt.text = "Pure Nonsense";
			genGrab = nonLvl;
				break;

		}

		switch (musLvl)
		{
		case 0:
			musTxt.text = "Long";
			break;

		case 1:
			//enable 1st exp bar
			musTxt.text = "Medium";
			break;
		case 2:
			//enable 2nd exp bar
			musTxt.text = "Short";
			break;
		case 3:
			//enable 3rd exp bar
			musTxt.text = "Fast";
			g1 = 100;
			g1Max.SetActive(true);
			break;

		}

		switch (vgLvl)
		{
		case 0:
			vgTxt.text = "Long";
			break;
			
		case 1:
			vgTxt.text = "Medium";
			break;
		case 2:
			vgTxt.text = "Short";
			break;
		case 3:
			vgTxt.text = "Fast";
			g2 = 100;
			g2Max.SetActive(true);
			break;
	}

		switch (polLvl)
		{
		case 0:
			polTxt.text = "Long";
			break;
			
		case 1:
			polTxt.text = "Medium";
			break;
		case 2:
			polTxt.text = "Short";
			break;
		case 3:
			polTxt.text = "Fast";
			g3 = 100;
			g3Max.SetActive(true);
			break;
		}

		switch (eduLvl)
		{
		case 0:
			eduTxt.text = "Long";
			break;
			
		case 1:
			eduTxt.text = "Medium";
			break;
		case 2:
			eduTxt.text = "Short";
			break;
		case 3:
			eduTxt.text = "Fast";
			g4 = 100;
			g4Max.SetActive(true);
			break;
		}

		switch (artLvl)
		{
		case 0:
			artTxt.text = "Long";
			break;
			
		case 1:
			artTxt.text = "Medium";
			break;
		case 2:
			artTxt.text = "Short";
			break;
		case 3:
			artTxt.text = "Fast";
			g5 = 100;
			g5Max.SetActive(true);
			break;
		}

		switch (nonLvl)
		{
		case 0:
			nonTxt.text = "Long";
			break;
			
		case 1:
			nonTxt.text = "Medium";
			break;
		case 2:
			nonTxt.text = "Short";
			break;
		case 3:
			nonTxt.text = "Fast";
			g6 = 100;
			g6Max.SetActive(true);
			break;
		}

}


	public void buttonClick()
	{
		if (!isClicked)
		{
			isClicked = true;
			genrePanel.SetActive(true);			
		}

		else 
		{
			isClicked = false;
			genrePanel.SetActive(false);
		}

	}

	public void Genre1()
	{
		genreSel = 1;
		isClicked = false;
		genrePanel.SetActive(false);
	}

	public void Genre2()
	{
		genreSel = 2;
		isClicked = false;
		genrePanel.SetActive(false);
	}

	public void Genre3()
	{
		genreSel = 3;
		isClicked = false;
		genrePanel.SetActive(false);
	}

	public void Genre4()
	{
		genreSel = 4;
		isClicked = false;
		genrePanel.SetActive(false);
	}

	public void Genre5()
	{
		genreSel = 5;
		isClicked = false;
		genrePanel.SetActive(false);
	}

	public void Genre6()
	{
		genreSel = 6;
		isClicked = false;
		genrePanel.SetActive(false);
	}
}

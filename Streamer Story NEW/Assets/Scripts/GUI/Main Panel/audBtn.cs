using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class audBtn : MonoBehaviour {

	public GameObject audPanel;
	private Text audTxt;
	public int audSel;
	public bool isClicked;

	//children
	public Text cT;
	public int cLvl;
	public int c1;
	public GameObject cMax;

	//teens
	public Text tT;
	public int tLvl;
	public int t1;
	public GameObject tMax;

	//adults
	public Text aT;
	public int aLvl;
	public int a1;
	public GameObject aMax;

	//everyone
	public Text eT;
	public int eLvl;
	public int e1;
	public GameObject eMax;

	public int audGrab;


	// Use this for initialization
	void Start () {
		audTxt = GetComponentInChildren<Text>();
		audSel = 0;


		cMax.SetActive(false);
		tMax.SetActive(false);
		aMax.SetActive(false);
		eMax.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

		if (c1 >= 100 && cLvl < 3)
		{
			cLvl++;
			int hold;
			hold = c1;
			hold -= 100;
			Debug.Log(hold);
			c1 = 0;
			c1 += hold;
			
		}
		
		if (t1 >= 100 && tLvl < 3)
		{
			tLvl++;
			int hold;
			hold = t1;
			hold -= 100;
			Debug.Log(hold);
			t1 = 0;
			t1 += hold;
		}
		
		if (a1 >= 100 && aLvl < 3)
		{
			aLvl++;
			int hold;
			hold = a1;
			hold -= 100;
			Debug.Log(hold);
			a1 = 0;
			a1 += hold;
		}
		
		if (e1 >= 100 && eLvl < 3)
		{
			eLvl++;
			int hold;
			hold = e1;
			hold -= 100;
			Debug.Log(hold);
			e1 = 0;
			e1 += hold;
		}


		switch (audSel)
		{
		case 0:
			audTxt.text = "Select an audience...";
			break;
			
		case 1:
			audTxt.text = "Children";
			audGrab = cLvl;
			break;
			
		case 2:
			audTxt.text = "Teens";
			audGrab = tLvl;
			break;
			
		case 3:
			audTxt.text = "Adults";
			audGrab = aLvl;
			break;
			
		case 4:
			audTxt.text = "Everyone";
			audGrab = eLvl;
			break;
			
		}

		switch (cLvl)
		{
		case 0:
			cT.text = "Long";
			break;
			
		case 1:
			//enable 1st exp bar
			cT.text = "Medium";
			break;
		case 2:
			//enable 2nd exp bar
			cT.text = "Short";
			break;
		case 3:
			//enable 3rd exp bar
			cT.text = "Fast";
			c1 = 100;
			cMax.SetActive(true);
			break;
			
		}

		switch (tLvl)
		{
		case 0:
			tT.text = "Long";
			break;
			
		case 1:
			//enable 1st exp bar
			tT.text = "Medium";
			break;
		case 2:
			//enable 2nd exp bar
			tT.text = "Short";
			break;
		case 3:
			//enable 3rd exp bar
			tT.text = "Fast";
			t1 = 100;
			tMax.SetActive(true);
			break;
			
		}

		switch (aLvl)
		{
		case 0:
			aT.text = "Long";
			break;
			
		case 1:
			//enable 1st exp bar
			aT.text = "Medium";
			break;
		case 2:
			//enable 2nd exp bar
			aT.text = "Short";
			break;
		case 3:
			//enable 3rd exp bar
			aT.text = "Fast";
			a1 = 100;
			aMax.SetActive(true);
			break;
			
		}

		switch (eLvl)
		{
		case 0:
			eT.text = "Long";
			break;
			
		case 1:
			//enable 1st exp bar
			eT.text = "Medium";
			break;
		case 2:
			//enable 2nd exp bar
			eT.text = "Short";
			break;
		case 3:
			//enable 3rd exp bar
			eT.text = "Fast";
			e1 = 100;
			eMax.SetActive(true);
			break;
			
		}
	}

	public void buttonClick()
	{
		if (!isClicked)
		{
			isClicked = true;
			audPanel.SetActive(true);
		}
		
		else 
		{
			isClicked = false;
			audPanel.SetActive(false);
		}
		
	}
	
	public void Genre1()
	{
		audSel = 1;
		isClicked = false;
		audPanel.SetActive(false);
	}
	
	public void Genre2()
	{
		audSel = 2;
		isClicked = false;
		audPanel.SetActive(false);
	}
	
	public void Genre3()
	{
		audSel = 3;
		isClicked = false;
		audPanel.SetActive(false);
	}
	
	public void Genre4()
	{
		audSel = 4;
		isClicked = false;
		audPanel.SetActive(false);
	}
	

}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class vidTypeBtn : MonoBehaviour {

	public GameObject vidTypePanel;
	private Text vidTypeTxt;
	public int vidTypeSel;
	public bool isClicked;

	//rush
	public Text rushTimeTxt;
	public int rushLvl;
	public int rush1;
	public GameObject rushMax;
	
	//regular
	public Text regularTimeTxt;
	public int regularLvl;
	public int reg1;
	public GameObject regMax;
	
	//detailed
	public Text detailedTimeTxt;
	public int detLvl;
	public int det1;
	public GameObject detMax;

	public int vidGrab;

	// Use this for initialization
	void Start () {
		vidTypeTxt = GetComponentInChildren<Text>();
		vidTypeSel = 0;

		rushMax.SetActive(false);
		regMax.SetActive(false);
		detMax.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

		if (rush1 >= 100 && rushLvl < 3)
		{
			rushLvl++;
			int hold;
			hold = rush1;
			hold -= 100;
			Debug.Log(hold);
			rush1 = 0;
			rush1 += hold;
			
		}
		
		if (reg1 >= 100 && regularLvl < 3)
		{
			regularLvl++;
			int hold;
			hold = reg1;
			hold -= 100;
			Debug.Log(hold);
			reg1 = 0;
			reg1 += hold;
		}
		
		if (det1 >= 100 && detLvl < 3)
		{
			detLvl++;
			int hold;
			hold = det1;
			hold -= 100;
			Debug.Log(hold);
			det1 = 0;
			det1 += hold;
		}


		switch (vidTypeSel)
		{
		case 0:
			vidTypeTxt.text = "Select a Video Type...";
			break;
			
		case 1:
			vidTypeTxt.text = "Rush";
			vidGrab = rushLvl;
			break;
			
		case 2:
			vidTypeTxt.text = "Regular";
			vidGrab = regularLvl;
			break;
			
		case 3:
			vidTypeTxt.text = "Detailed";
			vidGrab = detLvl;
			break;
			
		}

		switch (rushLvl)
		{
		case 0:
			rushTimeTxt.text = "-30%";
			break;
			
		case 1:
			//enable 1st exp bar
			rushTimeTxt.text = "-40%";
			break;
		case 2:
			//enable 2nd exp bar
			rushTimeTxt.text = "-50%";
			break;
		case 3:
			//enable 3rd exp bar
			rushTimeTxt.text = "-60%";
			rush1 = 100;
			rushMax.SetActive(true);
			break;
		}

		switch (regularLvl)
		{
		case 0:
			regularTimeTxt.text = "Regular";
			break;
			
		case 1:
			//enable 1st exp bar
			regularTimeTxt.text = "-10%";
			break;
		case 2:
			//enable 2nd exp bar
			regularTimeTxt.text = "-20%";
			break;
		case 3:
			//enable 3rd exp bar
			regularTimeTxt.text = "-30%";
			reg1 = 100;
			regMax.SetActive(true);
			break;
		}

		switch (detLvl)
		{
		case 0:
			detailedTimeTxt.text = "+50%";
			break;
			
		case 1:
			//enable 1st exp bar
			detailedTimeTxt.text = "+40%";
			break;
		case 2:
			//enable 2nd exp bar
			detailedTimeTxt.text = "+30%";
			break;
		case 3:
			//enable 3rd exp bar
			detailedTimeTxt.text = "+20%";
			det1 = 100;
			detMax.SetActive(true);
			break;
		}
	}

	public void buttonClick()
	{
		if (!isClicked)
		{
			isClicked = true;
			vidTypePanel.SetActive(true);
		}
		
		else 
		{
			isClicked = false;
			vidTypePanel.SetActive(false);
		}
		
	}
	
	public void Genre1()
	{
		vidTypeSel = 1;
		isClicked = false;
		vidTypePanel.SetActive(false);
	}
	
	public void Genre2()
	{
		vidTypeSel = 2;
		isClicked = false;
		vidTypePanel.SetActive(false);
	}
	
	public void Genre3()
	{
		vidTypeSel = 3;
		isClicked = false;
		vidTypePanel.SetActive(false);
	}

}

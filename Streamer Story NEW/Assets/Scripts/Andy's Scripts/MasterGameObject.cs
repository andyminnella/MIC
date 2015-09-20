using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MasterGameObject : MonoBehaviour {
	#region Variables
    /// <summary>
    /// fuck u everyone
    /// </summary>
	public static int money;
    private TimeTxt timer = new TimeTxt();
 
	public static int progress;
    private int overhead =0;
    private int rent=0;
    private int staffCost=0;
    private bool isStreaming;
    


    //shit andy added
    public GameObject gameTime ;
    private Stream newStream = new Stream();

    public Button buyR2Btn;
	
    private Rooms HQ;

	private Rooms[] rm = new Rooms[4];

    private Personnel[] employee = new Personnel[4];
    private int totalEnergy, startEnergy;

    private int maxEmp = 1;
    
    public GameObject purchased1;
    public GameObject purchased2;
    public GameObject purchased3;
    public GameObject purchased4;

    public GameObject moveHQBtn, stopStreamBtn;
    public Text EmpTxt, moneyTxt,streamTitle,energyTxt;

    private bool energyRunOnce;


    


    //stream quality  states
    public enum strQuality
    {
        terrible = 0,
        poor,
        average,
        abvAverage,
        good,
        great,
        amazing,
        perfection,

    }
    //

    
	#endregion

    #region stream functions
    //stops stream when energy is over
    IEnumerator streamTimer(int energy)
    {
        yield return new WaitForSeconds(energy);

        if (isStreaming)
        {
            stopStreamButton();
        }
        
    }
    
    // checks if streaming is allowed
    public bool checkStream()
    {
        if (streamTitle.text == "" || isStreaming == true)
        {
            Debug.Log("enter a name");
            return false;
        }
        else
            return true;
    }
    //function to start stream checks if allowed first
    public void streamBtn()
    {
        if (checkStream())
        {

            Debug.Log("Stream started");
            isStreaming = true;
            stopStreamBtn.SetActive(true);
            StartCoroutine(streamTimer(totalEnergy));
            startEnergy = totalEnergy;
        }
        else if(!checkStream())
        {
            Debug.Log("Stream in progress");
            return;
        }
        
        
        StopCoroutine(streamTimer(totalEnergy));
        
    }
    //function to stop stream
    public void stopStreamButton()
    {
        StopCoroutine(streamTimer(totalEnergy));
        newStream.startStream(startEnergy - totalEnergy, strQuality.terrible, 10, 10, 10);
        Debug.Log(newStream.getCash());
        money += newStream.getCash();
        isStreaming = false;
        stopStreamBtn.SetActive(false);
        Debug.Log("Stream has Ended");

    }

    #endregion

    #region room functions
    public Rooms getRoom(int i)
	{
		return rm [i];
	}

   

    #endregion

    #region employee functions

    // counts number of employees employed

    public int countEmployees(Personnel[] empList)
    {
        int numEmp = 0;
        int length = empList.Length;
        for (int i = 0; i < length; i++)
        {
            if (empList[i].getHired())
            {
                numEmp++;
            }
        }
        return numEmp;
    }
    //calculates total energy to display on screen
    public int calcTotalEnergy(Personnel[] empList)
    {
        int totalEnergy= 0;
        for (int i = 0; i < empList.Length; i++)
        {
            if (empList[i].getHired())
                totalEnergy += empList[i].getEnergy();
        }
        return totalEnergy;
    }
    #endregion


    // Use this for initialization
    void Start()
    {

        
		//initialize rooms and employees 0-3
		for (int i = 0; i < 4; i++) 
		{
			rm[i] = new Rooms(i+1);
            employee[i] = new Personnel();

            switch (i)
            {
                case 0:
                    rm[i].setBought(true);
                    rm[i].setCost(0);
                    employee[i].setHired(true);
                    employee[i].setEnergy(15);
                    break;
                case 1:
                    rm[i].setCost(200);
                    rm[i].setMaxEmp(2);
                    break;
                case 2:
                    rm[i].setCost(500);
                    rm[i].setMaxEmp(4);
                    break;
                case 3:
                    rm[i].setCost(800);
                    rm[i].setMaxEmp(6);
                    break;
            }
            

		}
		HQ = rm [0];
        //end of shit i added
		
		
		money = 1000;
		progress = 0;
        totalEnergy = calcTotalEnergy(employee);
	}
    
	
	// Update is called once per frame
	void Update () {
        if (!energyRunOnce && !timer.paused)
        {
            StartCoroutine(energyCounter());
            energyRunOnce = true;
        }
        EmpTxt.text = "Employees: " + countEmployees(employee) + "/" + maxEmp;
        moneyTxt.text = "money: $" + money;
        
        energyTxt.text = "Total Energy: " + totalEnergy;
        
	}
    /// <summary>
    /// counter that adds energy every 4 seconds
    /// </summary>
    /// <returns></returns>
    IEnumerator energyCounter()
    {
        yield return new WaitForSeconds(4);
        if (!isStreaming)
        {
            totalEnergy++;
            Debug.Log("energyCounter Active");

        }
        else
        {
            totalEnergy -= 3;
        }
        energyRunOnce = false;
        StopCoroutine(energyCounter());

    }

	#region BusinessPanel buttons

    public void moveHQ()
    {
        moveHQBtn.SetActive(true);
    }

	public void changeHQ(int room)
	{
		HQ = rm [room];
        maxEmp = rm[room].getMaxEmp();
	}

    public void buyRoom1()
    {
        if (rm[0].isPurchased() == true)
        {
            changeHQ(0);
        }
        else
        {
            changeHQ(0);
            money -= HQ.getCost();
        }
        
    }

	public void buyRoom2()
	{
        if (rm[1].isPurchased() == true)
        {
            changeHQ(1);
        }
        else if (money >= rm[1].getCost())
        {
            purchased2.SetActive(true);
            rm[1].setBought(true);
            changeHQ(1);
            money -= HQ.getCost();
        }
        
	}

    public void buyRoom3()
    {
        if (rm[2].isPurchased() == true)
        {
            changeHQ(2);
        }
        else if(money >= rm[2].getCost())
        {
            purchased3.SetActive(true);
            rm[2].setBought(true);
            changeHQ(2);
            money -= HQ.getCost();
        }
        
    }

    public void buyRoom4()
    {
        if (rm[3].isPurchased() == true)
        {
            changeHQ(3);
        }
        else if(money >= rm[3].getCost())
        {
            purchased4.SetActive(true);
            rm[3].setBought(true);
            changeHQ(3);
            money -= HQ.getCost();
        }
        
    }
	#endregion
	
}

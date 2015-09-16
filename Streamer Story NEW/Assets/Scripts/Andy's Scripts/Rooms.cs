using UnityEngine;

using System.Collections;

public class Rooms : MonoBehaviour {

	private int maxEmp = 1;
	private int cost = 100;
	private bool bought = false;
    


	public Rooms(int newMax)
	{
		maxEmp = newMax;
	}
    public void setBought(bool buy)
    {
        bought = buy;
    }

    public void setCost(int newCost)
    {
        cost = newCost;
    }

	public bool isPurchased()
	{
		return bought;
	}
	public int getCost()
	{
		return cost;
	}
    public int getMaxEmp()
    {
        return maxEmp;
    }
    public void setMaxEmp(int newMax)
    {
        maxEmp = newMax;
    }
}

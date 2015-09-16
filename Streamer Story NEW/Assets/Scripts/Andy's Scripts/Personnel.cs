using UnityEngine;
using System.Collections;

public class Personnel : MonoBehaviour {
	private bool isHired = false;
	private string name;
	private string description;


	//skills
	private int charisma,computer,skill = 2;

    private int level, exp, energy;

	//cost per month
	private int costPerMonth = 350;

	public Personnel()
	{

	}

	
	

	public void setChr(int newChr)
	{
		charisma = newChr;
	}
	public int getChr()
	{
		return charisma;
	}
    public int getEnergy()
    {
        return energy;
    }

    public void setEnergy(int newEnergy)
    {
        energy = newEnergy;
    }

    public void setComp(int newComp)
    {
        computer = newComp;
    }
    public int getComp()
    {
        return computer;
    }

    public int getEXP()
    {
        return exp;
    }
    public void setEXP(int newEXP)
    {
        exp = newEXP;
    }


	public void setSkill(int newSkill)
	{
		skill = newSkill;
	}
	public int getSkill()
	{
		return skill;
	}

	public void setCost(int newCost)
	{
		costPerMonth = newCost;
	}
	public int getCost()
	{
		return costPerMonth;
	}

	public void setHired(bool hired)
	{
		isHired = hired;
	}
	public bool getHired()
	{
		return isHired;
	}


	public void setName(string newName)
	{
		name = newName;
	}
	public string getName()
	{
		return name;
	}

	public void setDesc(string newDesc)
	{
		description = newDesc;
	}
	public string getDesc()
	{
		return description;
	}

}

using UnityEngine;
using System.Collections;

public class testDebug : MonoBehaviour {

	public NewEvent eventObj;


	//make function to continually deduct cash at end of each month


	public void eventRent()
	{
		eventObj.Create("Rent is due" , "This is just a test for further events and -350 money");
		MasterGameObject.money -=350;
	}
}

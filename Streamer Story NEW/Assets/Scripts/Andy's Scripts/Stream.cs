using UnityEngine;

using UnityEngine.UI;
using System.Collections;

public class Stream : MonoBehaviour
{
    
    #region variables
    
    private int energy, cashPerStream;
    private float length;
    private bool isStreaming;

    public float interval= 5f;
    public int cashPerInt = 2;
    private MasterGameObject.strQuality quaility;
    #endregion

    //function that starts the stream takes in energy quality skill charm comp
    public void startStream(int energy, MasterGameObject.strQuality strQuality, int skill, int charm, int comp)
    {
        cashPerInt = Random.RandomRange(1, 15);
        int numInterval;
        isStreaming = true;
        if (energy < 10)
        {
            
            Debug.Log("failed to stream, energy too low");
            return;
        }
        length = energy;
        numInterval = (int)length / (int)interval;
        cashPerStream = numInterval * cashPerInt;
        
        

    }
    //returns cash earned from stream
    public int getCash()
    {
        return cashPerStream;
    }


    
    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

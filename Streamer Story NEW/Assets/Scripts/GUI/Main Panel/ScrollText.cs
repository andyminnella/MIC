using UnityEngine;
using System.Collections;

public class ScrollText : MonoBehaviour {

	private Vector3 homeS;

	void Start () 
	{
		homeS = transform.position;
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.left * Time.deltaTime * 35 * Random.Range(1,2));

		if (transform.position.x <=  homeS.x - 260f) 
		{
			transform.position = new Vector2( homeS.x + 20f, transform.position.y);

		}
	}


}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Options : MonoBehaviour {

	private float sfxVolume;
	private Text sfxTxt;
	private float musVolume;
	private Text musTxt;
	// Use this for initialization
	void Start () {
		musTxt = GameObject.Find("MusicNum").GetComponent<Text>();
		sfxTxt = GameObject.Find("sfxNum").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MusicVolume(float musicVolumeValue)
	{
		musVolume = musicVolumeValue;
		musTxt.text = "" + Mathf.RoundToInt(musVolume);
	}

	public void SfxVolume(float sfxVolumeValue)
	{
		sfxVolume = sfxVolumeValue;
		sfxTxt.text = "" + Mathf.RoundToInt(sfxVolume);
	}
}

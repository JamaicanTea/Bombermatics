using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
	public Text timer;
	public float time = 30.0f;
	public GameObject gameOver;
	public GameObject resetButton;
	// Use this for initialization
	void Awake () 
	{
		Time.timeScale = 1;
		timer.text = time.ToString ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		time -= Time.deltaTime;
		DisplayTime ();
		if (time < 0) 
		{
			GameOver ();
		}
	}

	void DisplayTime ()
	{
		timer.text = "" + Mathf.Round (time);
	}

	void GameOver()
	{
		Time.timeScale = 0;
		gameOver.gameObject.SetActive (true);
		resetButton.gameObject.SetActive (true);
	}
}

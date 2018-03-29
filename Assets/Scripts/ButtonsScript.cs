using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour {
	public GameObject gameOver;
	public GameObject resetButton;

	// Use this for initialization
	public void RightAnswer () 
	{
		SceneManager.LoadScene ("GameScene2");	
	}

	public void RightAnswer2 () 
	{
		SceneManager.LoadScene ("GameScene3");	
	}
	public void RightAnswer3 () 
	{
		SceneManager.LoadScene ("GameScene4");	
	}
	public void RightAnswer4 () 
	{
		SceneManager.LoadScene ("GameScene2");	
	}
	// Update is called once per frame
	public void GameOver () 
	{
		Time.timeScale = 0;
		gameOver.gameObject.SetActive (true);
		resetButton.gameObject.SetActive (true);
	}
}

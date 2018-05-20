using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController Control;
	public static GameObject HUD;

	public float budget; 

	public float daysLeft;

	//public string[] unlockedSites;
	public List<string> unlockedSites = new List<string> ();
	public int tokensObtained;


	Text moneyText;
	Text timeText;

	// Use this for initialization
	void Awake () {

		if (Control == null) 
		{
			Control = this;
		}else {
				Destroy (this.gameObject);
		       }

		DontDestroyOnLoad (this.gameObject);
	}

	void Start ()
	{

		moneyText = GameObject.Find ("Money").GetComponent<Text>();
		timeText = GameObject.Find ("Clock").GetComponent<Text> ();

		//DontDestroyOnLoad (GameObject.Find ("HUD"));
		UpdateText ();
	}


	public void changeBudget(float ammount)
	{
		budget += ammount;
		UpdateText ();
	}

	public void SpendTime(float timeSpent)
	{
		daysLeft -= timeSpent;
		UpdateText ();
	}

	public void UpdateText()
	{ 
		moneyText.text = "$ " + budget.ToString ();
 
		timeText.text = daysLeft.ToString ();
	}

	void OnSceneLoaded()
	{
		UpdateText ();
		Debug.Log ("Texts Updated");
	}
}

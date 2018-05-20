using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navToMap : MonoBehaviour {

	public string price;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gotMapCorrect()
    {
        GameController.Control.unlockedSites.Add(price);
        GameController.Control.SpendTime(0.5f);
        GameController.Control.changeBudget(-3f);
        SceneManager.LoadScene("MainMap",LoadSceneMode.Single);
    }

    public void gotMapWrong()
    {
        
        GameController.Control.SpendTime(0.5f);
        GameController.Control.changeBudget(-3f);
        SceneManager.LoadScene("MainMap", LoadSceneMode.Single);

    }
}

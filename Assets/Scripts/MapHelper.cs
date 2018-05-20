using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapHelper : MonoBehaviour {

	public Text placeName;

	public Text placeDescription;

	public string destinationConfirmation;

	public Button travelBtn;

	/// <summary>
	/// In this function when the player clicks a location will open the info panel an change all the textes to show the correct INFO
	/// </summary>
	public void OpenMe(string title, string description, string destinationScene)
	{
		destinationConfirmation = destinationScene;
		placeName.text = title;
		placeDescription.text = description;
		
	}

	public void TravelTo()
	{
		GameController.Control.changeBudget (-1.5f);
		SceneManager.LoadScene (destinationConfirmation, LoadSceneMode.Single);
	}



}

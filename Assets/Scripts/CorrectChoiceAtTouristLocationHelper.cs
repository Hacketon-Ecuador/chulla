using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectChoiceAtTouristLocationHelper : MonoBehaviour {

	IEnumerator GetToken()
	{
		yield return new WaitForSeconds (2);

		GameController.Control.tokensObtained ++;

		if (GameController.Control.tokensObtained >= 3) 
		{
			GameController.Control.unlockedSites.Add ("MuseoIntinan");
		}

		SceneManager.LoadScene ("MainMap", LoadSceneMode.Single);
	}

public void StartGetToken()
	{
		StartCoroutine (GetToken());
	}

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TravelPoint : MonoBehaviour {

	public string destination;

	public string destinationTitle;

	public string destinationDescription;

	public GameObject infoPanel;

	public void OpenInfoPanel()
	{
		infoPanel.SetActive (true);

		infoPanel.GetComponentInChildren<MapHelper>().OpenMe(destinationTitle,destinationDescription,destination);
	}
}

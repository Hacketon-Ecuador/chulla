using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MapControler : MonoBehaviour {

	public GameObject[] travelBtns;


	// Use this for initialization
	void Start () {

		foreach (GameObject btn in travelBtns) 
		{
			if (GameController.Control.unlockedSites.Contains(btn.name))
			{
				btn.SetActive (true);
			}
		}
		
	}
	



}

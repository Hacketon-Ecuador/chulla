using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDdestroyer : MonoBehaviour {

	public static HUDdestroyer HUD;


	// Use this for initialization
	void Start () {

		if (HUD == null) {
			HUD = this;
		} else {
			Destroy (this.gameObject);
		}

		DontDestroyOnLoad (HUD.gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

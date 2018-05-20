using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMover : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update ()
	{
			this.transform.Translate (Vector2.up * speed, Space.World);
	}

	void OnBecameInvisible() {
		Destroy(this.gameObject);
	}
}

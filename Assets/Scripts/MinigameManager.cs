using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour {


	public static MinigameManager Control;

	public float spawnDelay;
	private float timeSinceSpawn = 0f;

	public float timeElapsed;

	public GameObject arrow;

	public bool startCounting;
	public bool playing;

	public float minutes;

	public float points = 500;

	public Scrollbar bar;

	void Start()
	{
		if (Control == null) 
		{
			Control = this;
		}
		playing = true;
	}

	// Update is called once per frame
	void Update () {

		bar.value = points / 1000;

		if (playing) {
			timeSinceSpawn ++;
			if (timeSinceSpawn > spawnDelay) {
				SpawnArrow ();
			}
		}

		if (startCounting) {
			points -= 0.5f;
		}

		if (points <= 0 && playing) 
		{
			playing = false;

			Lose();
		}

		if (minutes >= 60 && playing) 
		{
			playing = false;
			Debug.Log("You win");
			Win();

		}else {
			minutes = Time.time;
			}
	}

	void Win()
	{
		StartCoroutine (GoBackToMap ());
		if (GameController.Control != null)
		{
			GameController.Control.changeBudget(5);
		}
	}

	void Lose()
	{
		Debug.Log ("You Lose");
		StartCoroutine (GoBackToMap ());
	}

	void SpawnArrow()
	{
		int arrowPos = Random.Range (0, 4);
		//Debug.Log (arrowPos);

		switch (arrowPos) 
		{
		case 0:
			Instantiate (arrow, new Vector3(-9f,-12,0), Quaternion.Euler (0,0,90));
			break;
		case 1:
			Instantiate (arrow, new Vector3(-4.5f,-12,0), Quaternion.Euler (0,0,0));
			break;
		case 2:
			Instantiate (arrow, new Vector3(0,-12,0), Quaternion.Euler (0,0,180));
			break;
		case 3:
			Instantiate (arrow, new Vector3(4.5f,-12,0), Quaternion.Euler (0,0,-90));
			break;
		}

		timeSinceSpawn = 0;
	}

	public void AddPoints(float pointsGaiend)
	{
		points += pointsGaiend;
	}

	IEnumerator GoBackToMap()
	{
		yield return new WaitForSeconds (2);

		SceneManager.LoadScene ("MainMap", LoadSceneMode.Single);
	}
}

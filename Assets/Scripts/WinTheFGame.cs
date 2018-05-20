using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTheFGame : MonoBehaviour {

	public void WinGame()
	{
		SceneManager.LoadScene ("Victory", LoadSceneMode.Single);
	}


}

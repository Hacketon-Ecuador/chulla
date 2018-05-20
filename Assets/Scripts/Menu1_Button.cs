using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu1_Button : MonoBehaviour {


    public GenericMenu gmenu;
    public GameObject prontWrong;
    public GameObject prontCorrect;

    // Use this for initialization
    void Start () {
        prontCorrect.SetActive(false);
        prontWrong.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onCLickMenu() {
        GameObject botton =this.gameObject;
        string nombreMenu = botton.name;
        string returnVal =  gmenu.menuOption(nombreMenu);
        if (returnVal != "wrong")
        {
            prontCorrect.SetActive(true);
        }
        else {
            prontWrong.SetActive(true);
        }
    }
}

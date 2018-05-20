using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericMenu : MonoBehaviour {

    public int opcion = 0;
    int[] opciones = new int[4];


    // Use this for initialization
    void Start() {       
            opcion = Random.Range(1, 5);           
            Debug.Log("Random " + opcion); 
    }

    // Update is called once per frame
    void Update() {

    }



    public string menuOption(string menuN)
    {
        string answer = "wrong";        
        string[] numMenu = menuN.Split('_');
        int numMenuInt = System.Convert.ToInt16 (numMenu[1]) ;

        if (numMenuInt == opcion)
        {
            answer = "LaCarolina";
            Debug.Log(answer);
            return answer;
        }

        Debug.Log(answer);
        return "wrong";
    }


 


}

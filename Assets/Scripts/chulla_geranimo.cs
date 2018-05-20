using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class chulla_geranimo : MonoBehaviour {

    private float timeIniAplic;
    private GameObject chulla;
    
    private int timeCurrent = 0;
    public caja_dialogo caja_dialog;
    public GameObject cajaDialogo;

    // Use this for initialization
    void Start () {
       // cajaDialogo = GameObject.Find("CajaDialogo");
        chulla = GameObject.Find("canvas_personaje");
        timeIniAplic = Time.fixedTime;
       
    }
	
	// Update is called once per frame
	void Update () {
          timeCurrent = System.Convert.ToInt16(Time.time - timeIniAplic);
        if (timeCurrent > 1 && timeCurrent < 3)
        {
            chulla.transform.Translate(new Vector3(0, 300f, 0) * Time.deltaTime * 1.3f);
           
        }
        if (timeCurrent > 2) {
    
            caja_dialog.aparecerCajaDialogo(cajaDialogo);
        }
          
        
    }
}

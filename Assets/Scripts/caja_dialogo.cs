using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja_dialogo : MonoBehaviour {

    
    GameObject cajaDialogo;
	// Use this for initialization
	void Start () {
       
       // texto = GameObject.Find("dialogo");
        cajaDialogo = GameObject.Find("CajaDialogo");
        this.ocultarCajaDialogo(cajaDialogo);

    }
	
	// Update is called once per frame
	void Update () {
    
    }


    public void aparecerCajaDialogo(GameObject go)
    {
        go.SetActive(true);     
    }

    public void ocultarCajaDialogo(GameObject go)
    {
        go.SetActive(false);    
    }
}

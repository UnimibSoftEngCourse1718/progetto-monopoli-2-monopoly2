using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggiungiProprieta : MonoBehaviour {
    public int player;
    public GameObject sv1;
    public GameObject sv2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddPropieta1()
    {
        sv1.active = true;
        //Mostra proprietà player attivo
        //do something
    }

    public void AddPropieta2()
    {
        sv2.active = true;

        //do something
    }


}

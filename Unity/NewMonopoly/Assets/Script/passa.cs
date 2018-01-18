using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passa : MonoBehaviour {

    private int contatoregiocatoreattivo = 1;
    public GameObject[] panelList = new GameObject[5];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void passaturno()
    {
        if (contatoregiocatoreattivo == 6)
        {
            contatoregiocatoreattivo = 0;
            panelList[contatoregiocatoreattivo].active = true;
            panelList[5].active = false;
            contatoregiocatoreattivo++;
        }
        else
        {
            panelList[contatoregiocatoreattivo].active = true;
            panelList[contatoregiocatoreattivo - 1].active = false;
            contatoregiocatoreattivo++;
        }  

        
    }
}

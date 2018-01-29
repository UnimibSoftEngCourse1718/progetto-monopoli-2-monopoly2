using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passa : MonoBehaviour {

    private int contatoregiocatoreattivo = 1;
    public GameObject[] panelList = new GameObject[5];

    // Use this for initialization
    
    public StateController controller;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseUp()
    {
        if ( controller.IsDoneRolling&&controller.IsDoneClicking == true)
        {
            Debug.Log("entrato nel if");

            controller.verifica = true;
            Passaturno();
        }
    }

    public void Passaturno()
    {
        if (controller.verifica == true)
        {
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

        
    }
}

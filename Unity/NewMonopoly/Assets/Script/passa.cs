using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class passa : MonoBehaviour {

    private int contatoregiocatoreattivo = 1;
    public GameObject[] panelList;
    public StateController controller;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseUp()
    {
        if (controller.IsDoneRolling && controller.IsDoneClicking == true)
        {
            controller.verifica = true;
            Passaturno();
        }
    }

    public void Passaturno()
    {
        if (controller.verifica == true)
        {
            GameObject.Find("Messaggi").GetComponent<Text>().text = "";
            GameObject.Find("Dado 1").GetComponent<Text>().text = "";
            GameObject.Find("Dado 2").GetComponent<Text>().text = "";
            GameObject.Find("Risultato Dadi").GetComponent<Text>().text = "";

            if (contatoregiocatoreattivo == controller.NumberOfPlayers) 
            {
                contatoregiocatoreattivo = 0;
                panelList[contatoregiocatoreattivo].SetActive(true);
                panelList[controller.NumberOfPlayers - 1].SetActive(false);
                contatoregiocatoreattivo++;
            }
            else
            {
                panelList[contatoregiocatoreattivo].SetActive(true);
                panelList[contatoregiocatoreattivo - 1].SetActive(false);
                contatoregiocatoreattivo++;
            }
        }
    }
}

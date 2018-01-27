using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Offri : MonoBehaviour {

    /*public Giocatore giocatore1;
    public Giocatore giocatore2;
    public Giocatore giocatore3;
    public Giocatore giocatore4;
    public Giocatore giocatore5;
    public Giocatore giocatore6;*/

    // Use this for initialization
    void Start() {
       // if (int.Parse(GameObject.Find("Inserisci_Soldi1").GetComponent<Text>().text) > CurrentPlayerID.Soldi; 
            GameObject.Find("Nonhaisoldi").active = false;

       // if (int.Parse(GameObject.Find("Inserisci_Soldi2").GetComponent<Text>().text) > )

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void unload()
    {
        GameObject.Find("Nonhaisoldi").active = false;
    }
}

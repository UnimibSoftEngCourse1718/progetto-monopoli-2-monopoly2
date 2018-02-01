using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VAIINPRIGIONE : MonoBehaviour {

    public Casella prigione;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        giocatore giocatoreAttivo = null;
        foreach (giocatore item in GameObject.FindObjectsOfType<giocatore>())
            if (item.attivo)
                giocatoreAttivo = item;

        GameObject.FindObjectOfType<StateController>().Avviso("Vai in prigione");
        giocatoreAttivo.contatorePrigione = 0;
        giocatoreAttivo.partenza = giocatoreAttivo.Muovi(giocatoreAttivo.partenza, prigione);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {
    StateController controller;
    giocatore giocatoreAttivo;
    // Use this for initialization
    void Start ()
    {
        controller = GameObject.FindObjectOfType<StateController>();
	}

	void OnMouseUp ()
    {
        giocatoreAttivo = controller.getGiocatoreAttivo();
        MandaInBancarotta();
    }

    void MandaInBancarotta()
    {
        giocatoreAttivo.Bancarotta();
    }

    void MandaInPrigione()
    {
        Casella prigione = null;
        foreach (Casella item in GameObject.FindObjectsOfType<Casella>())
        {
            if (item.name == "11")
            {
                prigione = item;
            }
        }
        giocatoreAttivo.contatorePrigione = 0;
        giocatoreAttivo.partenza = giocatoreAttivo.Muovi(giocatoreAttivo.partenza, prigione);
    }
}

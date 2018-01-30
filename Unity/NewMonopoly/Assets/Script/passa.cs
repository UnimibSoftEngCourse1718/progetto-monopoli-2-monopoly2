using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class passa : MonoBehaviour {

    private int contatoreGiocatoreAttivo = 0;
    public GameObject[] listaOverlay;
    public giocatore[] listaGiocatori;
    public StateController controller;

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

            int vecchioGiocatore = contatoreGiocatoreAttivo;
            for (int i = contatoreGiocatoreAttivo; i < listaGiocatori.Length; i++)
            {
                if (i == listaGiocatori.Length - 1)
                {
                    i = -1;
                    contatoreGiocatoreAttivo = 0;
                }
                if (listaGiocatori[i + 1] != null)
                {
                    contatoreGiocatoreAttivo = i + 1;
                    i = listaGiocatori.Length;
                }
            }

            listaOverlay[contatoreGiocatoreAttivo].SetActive(true);
            listaGiocatori[contatoreGiocatoreAttivo].attivo = true;

            listaOverlay[vecchioGiocatore].SetActive(false);
            listaGiocatori[vecchioGiocatore].attivo = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class passa : MonoBehaviour
{
    public GameObject[] listaOverlay;
    public giocatore[] listaGiocatori;
    public StateController controller;

    public void OnMouseUp()
    {
        if (controller.IsDoneRolling && controller.IsDoneClicking == true)
        {
            controller.IsDoneRolling = false;
            controller.IsDoneClicking = false;
            GameObject.Find("Dado 1").GetComponent<Text>().text = "";
            GameObject.Find("Dado 2").GetComponent<Text>().text = "";
            GameObject.Find("Risultato Dadi").GetComponent<Text>().text = "";
            if (controller.doppio == 0)
            {
                int vecchioGiocatore = controller.CurrentPlayerId;
                for (int i = controller.CurrentPlayerId; i < listaGiocatori.Length; i++)
                {
                    if (i == listaGiocatori.Length - 1)
                    {
                        i = -1;
                        controller.CurrentPlayerId = 0;
                    }
                    if (listaGiocatori[i + 1] != null)
                    {
                        controller.CurrentPlayerId = i + 1;
                        i = listaGiocatori.Length;
                    }
                }
                listaOverlay[controller.CurrentPlayerId].SetActive(true);
                listaGiocatori[controller.CurrentPlayerId].attivo = true;


                listaOverlay[vecchioGiocatore].SetActive(false);
                listaGiocatori[vecchioGiocatore].attivo = false;
            }
            controller.NewTurn();
        }
    }
}

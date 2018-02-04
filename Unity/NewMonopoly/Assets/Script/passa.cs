using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class passa : MonoBehaviour
{
    public GameObject[] listaOverlay;
    public giocatore[] listaGiocatori;
    StateController Controller { get; set; }

    private void Start()
    {
        Controller = GameObject.FindObjectOfType<StateController>();
    }

    public void OnMouseUp()
    {
        if (Controller.IsDoneRolling && Controller.IsDoneClicking)
        {
            Controller.IsDoneRolling = false;
            Controller.IsDoneClicking = false;
            GameObject.Find("Dado 1").GetComponent<Text>().text = "";
            GameObject.Find("Dado 2").GetComponent<Text>().text = "";
            GameObject.Find("Risultato Dadi").GetComponent<Text>().text = "";
            if (Controller.Doppio == 0)
            {
                int vecchioGiocatore = Controller.CurrentPlayerId;
                for (int i = Controller.CurrentPlayerId; i < listaGiocatori.Length; i++)
                {
                    if (i == listaGiocatori.Length - 1)
                    {
                        i = -1;
                        Controller.CurrentPlayerId = 0;
                    }
                    if (listaGiocatori[i + 1] != null)
                    {
                        Controller.CurrentPlayerId = i + 1;
                        i = listaGiocatori.Length;
                    }
                }
                listaOverlay[Controller.CurrentPlayerId].SetActive(true);
                listaGiocatori[Controller.CurrentPlayerId].Attivo = true;

                listaOverlay[vecchioGiocatore].SetActive(false);
                listaGiocatori[vecchioGiocatore].Attivo = false;
            }
            Controller.NewTurn();
        }
    }
}

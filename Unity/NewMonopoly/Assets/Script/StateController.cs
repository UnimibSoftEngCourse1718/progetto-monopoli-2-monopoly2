using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour
{
    // Modificate questo numero per avere n giocatori senza dover 
    // far partire il play di unity dal menu principale
    static public int giocatoriSelezionati = 3;
    public GameObject[] listaGiocatori;
    public bool verifica = false;
    public int NumberOfPlayers;
    public int CurrentPlayerId = 0;
    Button pulsante;
    public int DiceTotal;
    public int doppio;
    public bool IsDoneRolling = false;
    public bool IsDoneClicking = false;
    public GameObject NoLegalMovesPopup;

    // Use this for initialization
    void Start()
    {
        NumberOfPlayers = giocatoriSelezionati;
        for (int i = 6; i > NumberOfPlayers; i--) 
        {
            //GameObject.Find("Player" + i).SetActive(false);
            //GameObject.Find("P" + i).SetActive(false);
            Destroy(GameObject.Find("Player" + i));
            Destroy(GameObject.Find("P" + i));
        }

        listaGiocatori = new GameObject[NumberOfPlayers];
        for (int i = 1; i <= NumberOfPlayers; i++)
        {
            listaGiocatori[i - 1] = GameObject.Find("P" + i);
            Debug.Log(GameObject.Find("P" + i));
        }
    }

    public void NewTurn()
    {
        IsDoneRolling = false;
        IsDoneClicking = false;
        verifica = false;

        for (int i = CurrentPlayerId; i < listaGiocatori.Length; i++)
        {
            if (i == listaGiocatori.Length - 1)
            {
                i = -1;
                CurrentPlayerId = 0;
            }

            if (listaGiocatori[i + 1] != null)
            {
                CurrentPlayerId = i + 1;
                i = listaGiocatori.Length;
            }
        }
    }

    public void RollAgain()
    {
        IsDoneRolling = false;
        IsDoneClicking = false;
        verifica = false;
        doppio++;
    }

    // Update is called once per frame
    void Update()
    {
        // È finito il turno?
        if (IsDoneRolling && IsDoneClicking && verifica == true )
        {
            NewTurn();
            return;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour
{
    // Modificate questo numero per avere n giocatori senza dover 
    // far partire il play di unity dal menu principale
    static public int giocatoriSelezionati = 6;
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
            Destroy(GameObject.Find("Player" + i));
            Destroy(GameObject.Find("P" + i));
        }

        listaGiocatori = new GameObject[NumberOfPlayers];
        for (int i = 1; i <= NumberOfPlayers; i++)
        {
            listaGiocatori[i - 1] = GameObject.Find("P" + i);
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

    static public void rimuoviGiocatore(giocatore g)
    {
        if (g == null)
            return;

        foreach (CasellaAcquistabile item in g.proprieta)
        {
            item.proprietario = null;
            item.cambioProprietario();
        }

        GameObject.Find("Messaggi").GetComponent<Text>().text = g.name + " È Stato eliminato";
        DestroyImmediate(GameObject.Find(g.name));

        if (GameObject.FindObjectsOfType<giocatore>().Length == 1)
        {
            GameObject.Find("Messaggi").GetComponent<Text>().text += "\n\nPartita Finita";
            GameObject.Find("TIRA").SetActive(false);
            GameObject.Find("PASSA").SetActive(false);
            GameObject.Find("COSTRUISCI").SetActive(false);
        }
    }
}
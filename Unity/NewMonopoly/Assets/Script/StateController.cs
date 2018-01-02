using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public int NumberOfPlayers = 2;
    public int CurrentPlayerId = 0;

    public int DiceTotal;

    public bool IsDoneRolling = false;
    public bool IsDoneAnimating = false;
    public bool IsDoneEnding = false;
    public void NewTurn()
    {
        //inizio turno azioni da fare prima di concludere il turno
        IsDoneRolling = false;
        IsDoneAnimating = false;
        //attributo per indicare che  il giocatore passa il turno quindi collegato al pulsante passa
        IsDoneEnding = false;

        CurrentPlayerId = (CurrentPlayerId + 1) % NumberOfPlayers;
    }

    // Update is called once per frame
    void Update()
    {

        ///se  ho tutto true il turno cambia
        if (IsDoneRolling && IsDoneEnding && IsDoneAnimating)
        {
            Debug.Log("Turno finito");
            NewTurn();
        }

    }
}
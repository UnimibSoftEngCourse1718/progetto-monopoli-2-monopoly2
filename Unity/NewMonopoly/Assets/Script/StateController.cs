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
    public int doppio;

    // NOTE: enum / statemachine is probably a stronger choice, but I'm aiming for simpler to explain.
    public bool IsDoneRolling = false;
    public bool IsDoneClicking = false;
    public bool IsDoneAnimating = false;
    public int AnimationsPlaying = 0;

    public GameObject NoLegalMovesPopup;


    public void NewTurn()
    {
        Debug.Log("NewTurn");
        
        IsDoneRolling = false;
        IsDoneClicking = false;
        IsDoneAnimating = false;

        CurrentPlayerId = (CurrentPlayerId + 1) % NumberOfPlayers;
    }

    public void RollAgain()
    {
        Debug.Log("RollAgain");
        IsDoneRolling = false;
        IsDoneClicking = false;
        IsDoneAnimating = false;
    }

    // Update is called once per frame
    void Update()
    {

        // Is the turn done?
        if (IsDoneRolling && IsDoneClicking == true )
        {
            Debug.Log("Turn is done!");
            NewTurn();
            return;
        }

        

    }

    
    
  }
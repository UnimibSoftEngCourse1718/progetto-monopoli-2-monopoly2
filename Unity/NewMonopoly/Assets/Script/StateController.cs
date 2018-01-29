using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }
    public bool verifica = false;
    public int NumberOfPlayers = 2;
    public int CurrentPlayerId = 0;
    Button pulsante;
    public int DiceTotal;
    public int doppio;

    // NOTE: enum / statemachine is probably a stronger choice, but I'm aiming for simpler to explain.
    public bool IsDoneRolling = false;
    public bool IsDoneClicking = false;


    public GameObject NoLegalMovesPopup;


    public void NewTurn()
    {
        Debug.Log("NewTurn");
        
        IsDoneRolling = false;
        IsDoneClicking = false;
        verifica = false;
        CurrentPlayerId = (CurrentPlayerId + 1) % NumberOfPlayers;
    }

    public void RollAgain()
    {
        Debug.Log("RollAgain");
        IsDoneRolling = false;
        IsDoneClicking = false;
        verifica = false;
        doppio++;
    }

    // Update is called once per frame
    
    void Update()
    {
       
        // Is the turn done?
      
        if (IsDoneRolling && IsDoneClicking && verifica == true )
        {
            Debug.Log("Turn is done!");
            NewTurn();
            return;
        }

        

    }

    
    
  }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RANDOM : MonoBehaviour {

    public Text[] text;
    public int risultato = 0; // Ogni volta che si tira si azzera il punteggio dei dadi

    
    public int doppio = 0;
    public StateController theStateController;

    // Use this for initialization
    void Start () {

        
    }
    // aggiungo lo statecontroller per controllare lo stato del turno e gestire  il giocatore di turno 

	
	// Update is called once per frame
	void Update () {
		
	}

    public void ok()
    {
        SceneManager.UnloadScene(3);
        SceneManager.LoadScene(2);
    }

    public void Randomizza()
    {   
        //controllo se ho già tirato
        if(theStateController.IsDoneRolling == true)
        {
            return;
        }
        text[0].text = UnityEngine.Random.Range(1, 7).ToString(); //Il 7 è escluso
        text[1].text = UnityEngine.Random.Range(1, 7).ToString();

        if (text[0].text.Equals(text[1].text)) doppio++;

        theStateController.IsDoneRolling = true;//tiro effettivo
     

        risultato = int.Parse(text[0].text) + int.Parse(text[1].text);
        text[2].text = risultato.ToString();
        theStateController.DiceTotal = risultato;

    }
}

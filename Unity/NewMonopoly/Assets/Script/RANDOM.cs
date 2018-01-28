using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RANDOM : MonoBehaviour {

    public Text[] text;
    public int risultato = 0; // Ogni volta che si tira si azzera il punteggio dei dadi
<<<<<<< HEAD
    public int doppio = 0;

=======
 
>>>>>>> 958de2ff3677e87e79b7683afe5ce3fed93198f0
    // Use this for initialization
    void Start () {

        theStateController = GameObject.FindObjectOfType<StateController>();
        
    }
    // aggiungo lo statecontroller per controllare lo stato del turno e gestire  il giocatore di turno 
   public StateController theStateController;
	
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
<<<<<<< HEAD
        if (text[0].text.Equals(text[1].text)) doppio++;
=======
     
>>>>>>> 958de2ff3677e87e79b7683afe5ce3fed93198f0
        risultato = int.Parse(text[0].text) + int.Parse(text[1].text);
        text[2].text = risultato.ToString();
        theStateController.DiceTotal = risultato;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RANDOM : MonoBehaviour {

    public bool Passa;
    public Text[] text;
    public int risultato = 0; // Ogni volta che si tira si azzera il punteggio dei dadi
    public StateController theStateController;

    public void ok()
    {
        SceneManager.UnloadScene(3);
        SceneManager.LoadScene(2);
    }

    public void Randomizza()
    {
        //controllo se ho già tirato
        if (theStateController.IsDoneRolling == true)
        {
            //controllo che io abbia passato prima di poter ritirare 
            return;
        }
        text[0].text = UnityEngine.Random.Range(1, 7).ToString(); //Il 7 è escluso
        text[1].text = UnityEngine.Random.Range(1, 7).ToString();

        theStateController.IsDoneRolling = true;//tiro effettivo

        risultato = int.Parse(text[0].text) + int.Parse(text[1].text);
        text[2].text = risultato.ToString();
        theStateController.DiceTotal = risultato;

        if (text[0].text.Equals(text[1].text))
        {
            theStateController.doppio++;
            theStateController.Avviso("Tiro Doppio!\nQuando passi il turono puoi tirare di nuovo!\nFallo tre volte di seguito e finisci in prigione\n( ͡° ͜ʖ ͡°)");
        }
        else
            theStateController.doppio = 0;
    }
}

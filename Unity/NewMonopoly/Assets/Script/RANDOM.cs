using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RANDOM : MonoBehaviour {
    // TODO // controllare cosa fa questo "Passa"
    public bool Passa;
    public Text[] text;
    public int risultato;
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
            return;
        risultato = 0;

        int dado1, dado2;
        dado1 = UnityEngine.Random.Range(1, 7);
        dado2 = UnityEngine.Random.Range(1, 7);
        text[0].text = dado1.ToString();
        text[1].text = dado2.ToString();

        theStateController.IsDoneRolling = true;//tiro effettivo

        risultato = dado1 + dado2;
        text[2].text = risultato.ToString();
        theStateController.DiceTotal = risultato;

        giocatore giocatoreAttivo = null;
        foreach (giocatore item in GameObject.FindObjectsOfType<giocatore>())
            if (item.attivo)
                giocatoreAttivo = item;

        if (giocatoreAttivo.contatorePrigione == -1)
        {
            if (dado1 == dado2)
            {
                theStateController.doppio++;
                theStateController.Avviso("Tiro Doppio!\nQuando passi il turno puoi tirare di nuovo!\n\nFallo tre volte di seguito e finisci in prigione");
            }
            else
            {
                theStateController.doppio = 0;
            }
        }
    }
}

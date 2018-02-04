using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RANDOM : MonoBehaviour
{
    public Text[] text;
    public int risultato { get; set; }
    StateController Controller { get; set; }

    public void Start()
    {
        Controller = GameObject.FindObjectOfType<StateController>();
    }

    public void Randomizza()
    {
        if (Controller.IsDoneRolling)
            return;
        risultato = 0;

        int dado1, dado2;
        dado1 = UnityEngine.Random.Range(1, 7);
        dado2 = UnityEngine.Random.Range(1, 7);
        text[0].text = dado1.ToString();
        text[1].text = dado2.ToString();

        Controller.IsDoneRolling = true;

        risultato = dado1 + dado2;
        text[2].text = risultato.ToString();
        Controller.DiceTotal = risultato;

        giocatore giocatoreAttivo = Controller.getGiocatoreAttivo();

        if (giocatoreAttivo.contatorePrigione == -1)
        {
            if (dado1 == dado2)
            {
                Controller.Doppio++;
                Controller.Avviso("Tiro Doppio!\nQuando passi il turno puoi tirare di nuovo!\n\nFallo tre volte di seguito e finisci in prigione", false);
            }
            else
            {
                Controller.Doppio = 0;
            }
        }

        giocatoreAttivo.GetComponent<BoxCollider>().enabled = true;
        Controller.Tira.interactable = false;
        Controller.DisattivaPulsantiFineTurno();
    }
}

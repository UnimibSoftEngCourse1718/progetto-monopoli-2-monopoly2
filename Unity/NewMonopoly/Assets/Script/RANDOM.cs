using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RANDOM : MonoBehaviour
{
    public bool Passa;
    public Text[] text;
    public int risultato;
    public StateController controller;

    public void ok()
    {
        SceneManager.UnloadSceneAsync(3);
        SceneManager.LoadScene(2);
    }

    public void Randomizza()
    {
        if (controller.IsDoneRolling == true)
            return;
        risultato = 0;

        int dado1, dado2;
        dado1 = UnityEngine.Random.Range(1, 7);
        dado2 = UnityEngine.Random.Range(1, 7);
        text[0].text = dado1.ToString();
        text[1].text = dado2.ToString();

        controller.IsDoneRolling = true;

        risultato = dado1 + dado2;
        text[2].text = risultato.ToString();
        controller.DiceTotal = risultato;

        giocatore giocatoreAttivo = controller.getGiocatoreAttivo();

        if (giocatoreAttivo.contatorePrigione == -1)
        {
            if (dado1 == dado2)
            {
                controller.doppio++;
                controller.Avviso("Tiro Doppio!\nQuando passi il turno puoi tirare di nuovo!\n\nFallo tre volte di seguito e finisci in prigione", false);
            }
            else
            {
                controller.doppio = 0;
            }
        }

        giocatoreAttivo.GetComponent<BoxCollider>().enabled = true;
        controller.Tira.interactable = false;
        controller.Passa.interactable = false;
        controller.Costruisci.interactable = false;
        controller.DisattivaTrattativa();
    }
}

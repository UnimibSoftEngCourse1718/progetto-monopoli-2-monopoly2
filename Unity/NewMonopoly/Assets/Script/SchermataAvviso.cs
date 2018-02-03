using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchermataAvviso : MonoBehaviour
{
    public GameObject schermata;
    public StateController controller;
    public bool attivoPulsanti { get; set; }
    float tempo;

    private void OnEnable()
    {
        controller.Passa.interactable = false;
        controller.Costruisci.interactable = false;
        tempo = Time.timeScale;
        Time.timeScale = 0;
    }

    public void pulsanteOK()
    {
        if (attivoPulsanti)
        {
            controller.Passa.interactable = true;
            controller.Costruisci.interactable = true;
        }
        Time.timeScale = tempo;
        schermata.SetActive(false);
    }
}

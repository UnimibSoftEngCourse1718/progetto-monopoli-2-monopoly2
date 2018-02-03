using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchermataAvviso : MonoBehaviour
{
    public GameObject schermata;
    public StateController controller;
    public bool attivoPulsanti { get; set; }

    private void OnEnable()
    {
        controller.Passa.interactable = false;
        controller.Costruisci.interactable = false;
        controller.DisattivaTrattativa();
        Time.timeScale = 0;
    }

    public void pulsanteOK()
    {
        if (attivoPulsanti)
        {
            controller.Passa.interactable = true;
            controller.Costruisci.interactable = true;
            controller.AttivaTrattativa();
        }
        Time.timeScale = 1;
        schermata.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchermataAvviso : MonoBehaviour
{
    public GameObject schermata;
    float tempo;

    private void OnEnable()
    {
        tempo = Time.timeScale;
        Time.timeScale = 0;
    }

    public void pulsanteOK()
    {
        Time.timeScale = tempo;
        schermata.SetActive(false);
    }
}

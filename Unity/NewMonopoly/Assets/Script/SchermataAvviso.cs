using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchermataAvviso : MonoBehaviour
{
    public GameObject schermata;
    StateController Controller { get; set; }
    public bool AttivoPulsanti { get; set; }

    private void Start()
    {
        Controller = GameObject.FindObjectOfType<StateController>();
    }

    private void OnEnable()
    {
        Controller = GameObject.FindObjectOfType<StateController>();
        Controller.DisattivaPulsantiFineTurno();
        Time.timeScale = 0;
    }

    public void pulsanteOK()
    {
        if (AttivoPulsanti)
            Controller.AttivaPulsantiFineTurno();

        Time.timeScale = 1;
        schermata.SetActive(false);
    }
}

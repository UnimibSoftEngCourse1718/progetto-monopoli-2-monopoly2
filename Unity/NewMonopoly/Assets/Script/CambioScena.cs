using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena : MonoBehaviour {

    public GameObject schermataesci;

    public void Adattivo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void ESCI()
    {
        Application.Quit();
    }

    public void view()
    {
        schermataesci.SetActive(true);
    }

    public void hide()
    {
        schermataesci.SetActive(false);
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttivo : MonoBehaviour
{
    public GameObject bga;
    public GameObject bga1;
    
    public GameObject offri1;
    public GameObject accetta1;
    public GameObject controproposta1;
    public GameObject rifiuta1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void offri()
    {
        offri1.active = false;
        accetta1.active = true;
        controproposta1.active = true;
        rifiuta1.active = true;
        bga.active = false;
        bga1.active = true;
    }

    public void accetta()
    {
        //COSE DA FARE QUANDO SI ACCETTA
        SceneManager.LoadScene(2);
    }

    public void controproposta()
    {
        bga.active = true;
        bga1.active = false;
    }

    


}


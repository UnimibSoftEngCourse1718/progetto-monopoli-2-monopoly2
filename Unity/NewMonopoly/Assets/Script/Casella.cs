using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casella : MonoBehaviour
{
    public Casella[] prossimaCasella;
    public Giocatore giocatore;
    // Use this for initialization
    void Start()
    {
        //Fermata();
    }

    void Fermata()
    {
        if (this.GetComponent<Stazione>().isActiveAndEnabled)
        {
            //Allora è una stazione
            Stazione stazione = this.GetComponent<Stazione>();
            UnityEngine.Debug.Log(stazione.ToString());
            return;
        }
        if (this.GetComponent<Terreno>().isActiveAndEnabled)
        {
            //Allora è un terreno
            Terreno terreno = this.GetComponent<Terreno>();
            UnityEngine.Debug.Log(terreno.ToString());
            return;
        }
        if (this.GetComponent<Societa>().isActiveAndEnabled)
        {
            //Allora è una società
            Societa societa = this.GetComponent<Societa>();
            UnityEngine.Debug.Log(societa.ToString());
            return;
        }
    }
}
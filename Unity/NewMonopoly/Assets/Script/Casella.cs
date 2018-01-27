using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casella : MonoBehaviour
{
    // Forse ho applicato lo strategy
    public Casella prossimaCasella;

    // Use this for initialization
    void Start()
    {

    }

    public virtual void Fermata(Giocatore giocatoreDiTurno) { }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casella : MonoBehaviour
{
    // Forse ho applicato lo strategy
    public Casella prossimaCasella;

    public virtual void Fermata(giocatore giocatoreDiTurno)
    {
        return;
    }
}
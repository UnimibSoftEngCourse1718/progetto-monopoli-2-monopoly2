using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casella : MonoBehaviour
{
    public Casella prossimaCasella;

    public virtual void Fermata(giocatore giocatoreDiTurno)
    {
        giocatoreDiTurno.controller.Passa.interactable = true;
        giocatoreDiTurno.controller.Costruisci.interactable = true;
    }
}
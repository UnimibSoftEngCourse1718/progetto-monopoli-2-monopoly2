using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stazione : CasellaAcquistabile
{
    public int costo = 200;
    public int ipoteca = 100;
    public int pedaggio = 25;
    public int pedaggio2Stazioni = 50;
    public int pedaggio3Stazioni = 100;
    public int pedaggio4Stazioni = 200;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (proprietario == null)
        {
            schermataAcquisto.stazione = this;
            schermataAcquisto.Visualizza();
        }
        else
        {
            int nStazioni = 0;
            foreach (Casella item in proprietario.proprieta)
            {
                if (item.name == "6" || item.name == "16" || item.name == "26" || item.name == "36")
                    nStazioni++;
            }

            if (nStazioni == 1)
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio);
            else if (nStazioni == 2)
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio2Stazioni);
            else if (nStazioni == 3)
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio3Stazioni);
            else if (nStazioni == 4)
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio4Stazioni);
        }
    }
}

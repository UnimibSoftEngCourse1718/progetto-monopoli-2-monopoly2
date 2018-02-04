using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stazione : CasellaAcquistabile
{
    public int Costo { get; set; }
    public int Pedaggio { get; set; }
    public int Pedaggio2Stazioni { get; set; }
    public int Pedaggio3Stazioni { get; set; }
    public int Pedaggio4Stazioni { get; set; }

    private void Start()
    {
        Costo = 200;
        Pedaggio = 25;
        Pedaggio2Stazioni = 50;
        Pedaggio3Stazioni = 100;
        Pedaggio4Stazioni = 200;
    }

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (proprietario == null)
        {
            schermataAcquisto.Stazione = this;
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
                giocatoreDiTurno.TrasferimentoDenaro(-Pedaggio);
            else if (nStazioni == 2)
                giocatoreDiTurno.TrasferimentoDenaro(-Pedaggio2Stazioni);
            else if (nStazioni == 3)
                giocatoreDiTurno.TrasferimentoDenaro(-Pedaggio3Stazioni);
            else if (nStazioni == 4)
                giocatoreDiTurno.TrasferimentoDenaro(-Pedaggio4Stazioni);

            giocatoreDiTurno.controller.AttivaPulsantiFineTurno();
        }
    }
}

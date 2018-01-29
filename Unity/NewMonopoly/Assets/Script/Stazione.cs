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
            // Terreno libero // Compra o Asta
        }
        else
        {
            // Terreno occupato // Pedaggio
            int nStazioni = 0;
            foreach (Casella item in proprietario.proprieta)
            {
                if (item.name == "6" || item.name == "16" || item.name == "26" || item.name == "36")
                    nStazioni++;
            }

            if (nStazioni == 0)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio);
            }
            else if (nStazioni == 1)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio2Stazioni);
            }
            else if (nStazioni == 2)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio3Stazioni);
            }
            else if (nStazioni == 3)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio4Stazioni);
            }
        }
        return;
    }

    public void PagaPedaggio(giocatore giocatoreDiTurno, int importo)
    {
        if (giocatoreDiTurno.soldi - importo >= 0)
        {
            giocatoreDiTurno.soldi -= importo;
            proprietario.soldi += importo;
        }
        else
        {
            // TODO // Non ho abbastanza soldi
        }
        return;
    }
}

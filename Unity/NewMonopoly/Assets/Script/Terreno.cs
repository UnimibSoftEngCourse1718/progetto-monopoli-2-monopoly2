using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : CasellaAcquistabile
{
    // Se si possiedono tutti i terreni di quel colore il pedaggio senza case si raddoppia
    // Se si possiedono tutti i terreni di quel colore è possibile costruire
    public int costo, ipoteca, costoEdificio, pedaggio, pedaggio1Casa, pedaggio2Case, pedaggio3Case, pedaggio4Case, pedaggioAlbergo, nEdifici;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (proprietario == null)
        {
            // Terreno libero // Compra o Asta
        }
        else
        {
            // Terreno occupato // Pedaggio
            if (nEdifici == 0)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio);
            }
            else if (nEdifici == 1)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio1Casa);
            }
            else if (nEdifici == 2)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio2Case);
            }
            else if (nEdifici == 3)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio3Case);
            }
            else if (nEdifici == 4)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggio4Case);
            }
            else if (nEdifici == 5)
            {
                PagaPedaggio(giocatoreDiTurno, pedaggioAlbergo);
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

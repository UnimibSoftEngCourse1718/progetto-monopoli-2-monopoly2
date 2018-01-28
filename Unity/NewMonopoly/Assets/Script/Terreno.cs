using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : Casella
{
    // Se si possiedono tutti i terreni di quel colore il pedaggio senza case si raddoppia
    // Se si possiedono tutti i terreni di quel colore è possibile costruire
    public int costo, ipoteca, costoEdificio, pedaggio, pedaggio1Casa, pedaggio2Case, pedaggio3Case, pedaggio4Case, pedaggioAlbergo, nEdifici;
    public giocatore proprietario ;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (proprietario == null)
        {
            // Terreno libero // Compra o Asta
        }
        else
        {
            // Terreno occupato // Pedaggio
            // TODO // Non ho abbastanza soldi
            if (nEdifici == 0)
            {
                giocatoreDiTurno.soldi -= pedaggio;
                //proprietario.soldi += pedaggio;
            }
            else if (nEdifici == 1)
            {
                giocatoreDiTurno.soldi -= pedaggio1Casa;
                proprietario.soldi += pedaggio1Casa;
            }
            else if (nEdifici == 2)
            {
                giocatoreDiTurno.soldi -= pedaggio2Case;
                proprietario.soldi += pedaggio2Case;
            }
            else if (nEdifici == 3)
            {
                giocatoreDiTurno.soldi -= pedaggio3Case;
                proprietario.soldi += pedaggio3Case;
            }
            else if (nEdifici == 4)
            {
                giocatoreDiTurno.soldi -= pedaggio4Case;
                proprietario.soldi += pedaggio4Case;
            }
            else if (nEdifici == 5)
            {
                giocatoreDiTurno.soldi -= pedaggioAlbergo;
                proprietario.soldi += pedaggioAlbergo;
            }
        }
        return;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probabilita : CasellaCarta
{
    private void Start()
    {
        tipo = "PROBABILITÀ";
        carte = new Carta[16];
        carte[0] = new Carta("Ritornate a Teramo", 0, 2, false);
        carte[1] = new Carta("È maturata la cedola delle vostre azioni: ritirate 40", 40, 0, true);
        carte[2] = new Carta("Rimborso tassa sul reddito: ritirate 20 dalla banca", 20, 0, true);
        carte[3] = new Carta("Avete vinto il secondo premio in un concorso di bellezza: ritirate 10", 10, 0, true);
        carte[4] = new Carta("Scade il vostro premio di assicurazione: pagate 50", -50, 0, true);
        carte[5] = new Carta("Uscite gratis di prigione la prossima volta che ci finite", 0, 0, true);
        carte[6] = new Carta("Avete vinto un premio di consolazione alla lotteria di Merano: ritirate 100", 100, 0, true);
        carte[7] = new Carta("Andate fino al via", 0, 1, false);
        carte[8] = new Carta("Pagate una multa di 30", -30, 0, true);
        carte[9] = new Carta("Siete creditori verso la banca di 200, ritirateli", 200, 0, true);
        carte[10] = new Carta("Avete perso una causa: pagate 100", -100, 0, true);
        carte[11] = new Carta("Andate in prigione direttamente e senza passare dal via", 0, 11, true);
        carte[12] = new Carta("Avete ceduto delle azioni: ricavate 50", 50, 0, true);
        carte[13] = new Carta("Pagate il conto del dottore di 50", -50, 0, true);
        carte[14] = new Carta("Ereditate 50 da un lontano parente", 50, 0, true);
        carte[15] = new Carta("Fate 3 passi indietro", 0, -3, false);
    }
}

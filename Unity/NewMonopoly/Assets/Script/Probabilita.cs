using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probabilita : CasellaCarta
{
    private void Start()
    {
        carte[0] = new Carta("ritornate al vicolo corto.", 25, 0);
        carte[1] = new Carta("è maturata la cedola delle vostre azioni: ritirate 60 euro", 25, 0);
        carte[2] = new Carta("rimborso tassa sul reddito: ritirate 50 euro dalla banca", 25, 0);
        carte[3] = new Carta("avete vinto il secondo premio in un concorso di bellezza: ritirate 25 euro", 25, 0);
        carte[4] = new Carta("scade il vostro premio di assicurazione: pagate 125 euro", 25, 0);
        carte[5] = new Carta("uscite gratis di prigione, se ci siete: potete conservare questo cartoncino oppure venderlo", 25, 0);
        carte[6] = new Carta("avete vinto un premio di consolazione alla lotteria di Merano: ritirate 250 euro", 25, 0);
        carte[7] = new Carta("andate fino al via", 25, 0);
        carte[8] = new Carta("pagate una multa di 25 euro, oppure prendete un cartoncino dagli imprevisti", 25, 0);
        carte[9] = new Carta("siete creditori verso la banca di 500 euro, ritirateli", 25, 0);
        carte[10] = new Carta("avete perso una causa: pagate 250 euro", 25, 0);
        carte[11] = new Carta("andate in prigione direttamente e senza passare dal via", 25, 0);
        carte[12] = new Carta("è il vostro compleanno: ogni giocatore vi regala 25 euro", 25, 0);
        carte[13] = new Carta("avete ceduto delle azioni: ricavate 125 euro", 25, 0);
        carte[14] = new Carta("pagate il conto del dottore: 125 euro", 25, 0);
        carte[15] = new Carta("ereditate 250 € da un lontano parente", 25, 0);
    }
}

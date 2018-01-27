using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imprevisto : CasellaCarta
{
    private void Start()
    {
        carte[0] = new Carta("andate sino al largo colombo: se passate dal via ritirate 500 euro", 25, 0);
        carte[1] = new Carta("andate in prigione direttamente e senza passare dal via", 25, 0);
        carte[2] = new Carta("", 25, 0);
        carte[3] = new Carta("fate 3 passi indietro", 25, 0);
        carte[4] = new Carta("andate sino a via accademia: se passate dal via ritirate 500 euro", 25, 0);
        carte[5] = new Carta("versate 50 euro per beneficenza", 25, 0);
        carte[6] = new Carta("andate alla stazione nord: se passate dal via ritirate 500 euro", 25, 0);
        carte[7] = new Carta("multa di 40 euro per aver guidato senza patente", 25, 0);
        carte[8] = new Carta("andate fino al parco della vittoria", 25, 0);
        carte[9] = new Carta("matrimonio in famiglia: spese impreviste 375 euro", 25, 0);
        carte[10] = new Carta("uscite gratis di prigione, se ci siete: potete conservare questo cartoncino oppure venderlo", 25, 0);
        carte[11] = new Carta("maturano le cedole delle vostre cartelle di rendita, ritirate 375 euro", 25, 0);
        carte[12] = new Carta("la banca vi paga gli interessi del vostro conto corrente, ritirate 125 euro", 25, 0);
        carte[13] = new Carta("andate avanti sino al via", 25, 0);
        carte[14] = new Carta("avente vinto un terno al lotto: ritirate 250 euro", 25, 0);
        carte[15] = new Carta("", 25, 0);
    }
}

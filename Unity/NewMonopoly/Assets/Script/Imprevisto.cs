using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imprevisto : CasellaCarta
{
    private void Start()
    {
        tipo = "IMPREVISTO";
        carte = new Carta[16];
        carte[0] = new Carta("Andate sino ad Ischia. Se passate dal via ritirate 200", 0, 25, true);
        carte[1] = new Carta("Andate in prigione direttamente e senza passare dal via", 0, 11, true);
        carte[2] = new Carta("Fate 3 passi indietro", 0, -3, true);
        carte[3] = new Carta("Andate sino a Cosenza. Se passate dal via ritirate 200", 0, 12, true);
        carte[4] = new Carta("Versate 20 per beneficenza", -50, 0, true);
        carte[5] = new Carta("Andate alla stazione nord. Se passate dal via ritirate 200", 0, 26, true);
        carte[6] = new Carta("Multa di 20 per aver guidato senza patente", -20, 0, true);
        carte[7] = new Carta("Andate fino a Chieti", 0, 40, true);
        carte[8] = new Carta("Matrimonio in famiglia: spese impreviste 150", -150, 0, true);
        carte[9] = new Carta("Uscite gratis di prigione la prossima volta che ci finite", 0, 0, true);
        carte[10] = new Carta("Maturano le cedole delle vostre cartelle di rendita, ritirate 150", 150, 0, true);
        carte[11] = new Carta("La banca vi paga gli interessi del vostro conto corrente, ritirate 75", 75, 0, true);
        carte[12] = new Carta("Andate avanti sino al via", 0, 1, true);
        carte[13] = new Carta("Avente vinto un terno al lotto: ritirate 100", 100, 0, true);
        carte[14] = new Carta("Fate 3 passi indietro", 0, -3, true);
        carte[15] = new Carta("Fate 3 passi indietro", 0, -3, true);
    }
}

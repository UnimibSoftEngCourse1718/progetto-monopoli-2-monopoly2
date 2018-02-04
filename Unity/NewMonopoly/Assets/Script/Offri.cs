using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Offri : MonoBehaviour
{
    public GameObject Nonhaisoldi;
    public Button b;
    public Text Offerta1;
    public Text Offerta2;

    public GameObject bga;
    public GameObject bga1;

    public GameObject offri1;
    public GameObject accetta1;
    public GameObject controproposta1;
    public GameObject rifiuta1;

    public GameObject annulla;

    public Text text1;
    public Text text2;

    public Text player2;

    public giocatore p1;
    public giocatore p2;
    public giocatore p3;
    public giocatore p4;
    public giocatore p5;
    public giocatore p6;

    public Text soldi1;
    public Text soldi2;
    public Text soldi3;
    public Text soldi4;
    public Text soldi5;
    public Text soldi6;

    public void controllo()
    {
        bool attiva = true;

        if (p1.Attivo)
        {
            if (int.Parse(Offerta1.text) > p1.soldi)
            {

                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if (p2.Attivo)
        {
            if (int.Parse(Offerta1.text) > p2.soldi)
            {

                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if (p3.Attivo)
        {
            if (int.Parse(Offerta1.text) > p3.soldi)
            {

                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if (p4.Attivo)
        {
            if (int.Parse(Offerta1.text) > p4.soldi)
            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if (p5.Attivo)
        {
            if (int.Parse(Offerta1.text) > p5.soldi)
            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if  (p6.Attivo)
            {
            if (int.Parse(Offerta1.text) > p6.soldi)
            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }

        if (player2.text.Equals("Player 1"))
        {
            if (int.Parse(Offerta2.text) > p1.soldi)

            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }

        }
        else if (player2.text.Equals("Player 2"))
        {
            if (int.Parse(Offerta2.text) > p2.soldi)
            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if (player2.text.Equals("Player 3"))
        {
            if (int.Parse(Offerta2.text) > p3.soldi)
            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if (player2.text.Equals("Player 4"))
        {
            if (int.Parse(Offerta2.text) > p4.soldi)
            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if (player2.text.Equals("Player 5"))
        {
            if (int.Parse(Offerta2.text) > p5.soldi)
            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        else if (player2.text.Equals("Player 6"))
        {
            if (int.Parse(Offerta2.text) > p6.soldi)
            {
                Nonhaisoldi.SetActive(true);
                b.gameObject.SetActive(true);
                attiva = false;
            }
        }
        if (attiva)
            offri();
    }
    public void unload()
    {
        Nonhaisoldi.SetActive(false);
        b.gameObject.SetActive(false);
    }

    public void accetta()
    {

        int oppertap1 = 0;
        int offertap2 = 0;

        if (Offerta1 != null)
            oppertap1 = int.Parse(Offerta1.text);
        if (Offerta2 != null)
            offertap2 = int.Parse(Offerta2.text);

        if (p1.Attivo)
        {
            p1.TrasferimentoDenaro(offertap2 - oppertap1);
        }
        else if (p2.Attivo)
        {
            p2.TrasferimentoDenaro(offertap2 - oppertap1);
        }
        else if (p3.Attivo)
        {
            p3.TrasferimentoDenaro(offertap2 - oppertap1);
        }
        else if (p4.Attivo)
        {
            p4.TrasferimentoDenaro(offertap2 - oppertap1);
        }
        else if (p5.Attivo)
        {
            p5.TrasferimentoDenaro(offertap2 - oppertap1);
        }
        else if (p6.Attivo)
        {
            p6.TrasferimentoDenaro(offertap2 - oppertap1);
        }

        if (player2.text.Equals("Player 1"))
        {
            p1.TrasferimentoDenaro(oppertap1 - offertap2);
        }
        else if (player2.text.Equals("Player 2"))
        {
            p2.TrasferimentoDenaro(oppertap1 - offertap2);
        }
        else if (player2.text.Equals("Player 3"))
        {
            p3.TrasferimentoDenaro(oppertap1 - offertap2);
        }
        else if (player2.text.Equals("Player 4"))
        {
            p4.TrasferimentoDenaro(oppertap1 - offertap2);
        }
        else if (player2.text.Equals("Player 5"))
        {
            p5.TrasferimentoDenaro(oppertap1 - offertap2);
        }
        else if (player2.text.Equals("Player 6"))
        {
            p6.TrasferimentoDenaro(oppertap1 - offertap2);
        }

        GameObject.Find("TRATTATIVA").SetActive(false);
        GameObject.FindObjectOfType<StateController>().AttivaPulsantiFineTurno();
    }

    public void offri()
    {
        offri1.SetActive(false);
        annulla.SetActive(false);
        accetta1.SetActive(true);
        controproposta1.SetActive(false);
        rifiuta1.SetActive(true);
        bga.SetActive(false);
        bga1.SetActive(true);
    }

    public void controproposta()
    {
        offri1.SetActive(true);
        annulla.SetActive(true);
        accetta1.SetActive(false);
        controproposta1.SetActive(false);
        rifiuta1.SetActive(false);
        bga.SetActive(false);
        bga1.SetActive(true);
        bga.SetActive(true);
        bga1.SetActive(false);
    }

}

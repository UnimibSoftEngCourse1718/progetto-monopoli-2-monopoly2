using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AggiungiProprieta : MonoBehaviour
{
    public GameObject sv1;
    public GameObject sv2;

    private string[] arr1 = new string[21];
    private string[] arr2 = new string[21];

    private int i = 0;
    private int y = 0;

    public Text prova;
    public Text prova1;

    public Text[] array1;
    public Text[] array2;

    public GameObject b1;
    public GameObject b2;

    public giocatore p1;
    public giocatore p2;
    public giocatore p3;
    public giocatore p4;
    public giocatore p5;
    public giocatore p6;

    public Text Player1;
    public Text Player2;

    public void AddPropieta1()
    {
        b1.SetActive(false);

        if (p1.attivo == true)
        {
            for (int r = 0; r < 20; r++)
            {
                array1[r].text = p1.proprieta[r].nomeCasella;
            }
        }
        else if (p2.attivo == true)
        {

            for (int r = 0; r < 20; r++)
            {
                array1[r].text = p2.proprieta[r].nomeCasella;
            }
        }
        else if (p3.attivo == true)
        {
            for (int r = 0; r < 20; r++)
            {
                array1[r].text = p3.proprieta[r].nomeCasella;
            }
        }
        else if (p4.attivo == true)
        {
            for (int r = 0; r < 20; r++)
            {
                array1[r].text = p4.proprieta[r].nomeCasella;
            }
        }
        else if (p5.attivo == true)
        {
            for (int r = 0; r < 20; r++)
            {
                array1[r].text = p5.proprieta[r].nomeCasella;
            }
        }
        else if (p6.attivo == true)
        {
            for (int r = 0; r < 20; r++)
            {
                array1[r].text = p6.proprieta[r].nomeCasella;
            }
        }
    }

    public void AddPropieta2()
    {
        b2.SetActive(false);

        if (Player2.text.Equals("Player 1"))
        {
            for (int r = 0; r < 20; r++)
            {
                array2[r].text = p1.proprieta[r].nomeCasella;
            }
        }

        if (Player2.text.Equals("Player 2"))
        {
            for (int r = 0; r < 20; r++)
            {
                array2[r].text = p2.proprieta[r].nomeCasella;
            }
        }

        if (Player2.text.Equals("Player 3"))
        {
            for (int r = 0; r < 20; r++)
            {
                array2[r].text = p3.proprieta[r].nomeCasella;
            }
        }

        if (Player2.text.Equals("Player 4"))
        {
            for (int r = 0; r < 20; r++)
            {
                array2[r].text = p4.proprieta[r].nomeCasella;
            }
        }

        if (Player2.text.Equals("Player 5"))
        {
            for (int r = 0; r < 20; r++)
            {
                array2[r].text = p5.proprieta[r].nomeCasella;
            }
        }

        if (Player2.text.Equals("Player 6"))
        {
            for (int r = 0; r < 20; r++)
            {
                array2[r].text = p6.proprieta[r].nomeCasella;
            }
        }
    }

    public void annulla1()
    {
        sv1.SetActive(false);
    }

    public void annulla2()
    {
        sv2.SetActive(false);
    }

    public void scegli1()
    {
        arr1[i] = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        i++;
        prova.text = arr1[0];
    }

    public void scegli2()
    {
        arr2[y] = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        y++;
        prova1.text = arr2[0];
    }

    public void accetta()
    {
        foreach (CasellaAcquistabile item in GameObject.FindObjectsOfType<CasellaAcquistabile>())
        {
            for (int z = 0; z < 21; z++)
            {
                if (item.nomeCasella == arr1[z])
                {
                    if (p1.attivo == true)
                    {
                        p1.RimuoviProprieta(item);
                    }
                    if (p2.attivo == true)
                    {
                        p2.RimuoviProprieta(item);
                    }
                    if (p3.attivo == true)
                    {
                        p3.RimuoviProprieta(item);
                    }
                    if (p4.attivo == true)
                    {
                        p4.RimuoviProprieta(item);
                    }
                    if (p5.attivo == true)
                    {
                        p5.RimuoviProprieta(item);
                    }
                    if (p6.attivo == true)
                    {
                        p6.RimuoviProprieta(item);
                    }


                    if (Player2.text.Equals("Player 1"))
                    {
                        p1.AggiungiProprieta(item);
                    }
                    if (Player2.text.Equals("Player 2"))
                    {
                        p2.AggiungiProprieta(item);
                    }
                    if (Player2.text.Equals("Player 3"))
                    {
                        p3.AggiungiProprieta(item);
                    }
                    if (Player2.text.Equals("Player 4"))
                    {
                        p4.AggiungiProprieta(item);
                    }
                    if (Player2.text.Equals("Player 5"))
                    {
                        p5.AggiungiProprieta(item);
                    }
                    if (Player2.text.Equals("Player 6"))
                    {
                        p6.AggiungiProprieta(item);
                    }
                }

                if (item.nomeCasella.Equals(arr2[z]))
                {
                    if (p1.attivo == true)
                    {
                        p1.AggiungiProprieta(item);
                    }
                    if (p2.attivo == true)
                    {
                        p2.AggiungiProprieta(item);
                    }
                    if (p3.attivo == true)
                    {
                        p3.AggiungiProprieta(item);
                    }
                    if (p4.attivo == true)
                    {
                        p4.AggiungiProprieta(item);
                    }
                    if (p5.attivo == true)
                    {
                        p5.AggiungiProprieta(item);
                    }
                    if (p6.attivo == true)
                    {
                        p6.AggiungiProprieta(item);
                    }


                    if (Player2.text.Equals("Player 1"))
                    {
                        p1.RimuoviProprieta(item);
                    }
                    if (Player2.text.Equals("Player 2"))
                    {
                        p2.RimuoviProprieta(item);
                    }
                    if (Player2.text.Equals("Player 3"))
                    {
                        p3.RimuoviProprieta(item);
                    }
                    if (Player2.text.Equals("Player 4"))
                    {
                        p4.RimuoviProprieta(item);
                    }
                    if (Player2.text.Equals("Player 5"))
                    {
                        p5.RimuoviProprieta(item);
                    }
                    if (Player2.text.Equals("Player 6"))
                    {
                        p6.RimuoviProprieta(item);
                    }
                }
            }
        }
        for (i = 0; i < 21; i++)
        {
            arr1[i] = "Nessuna Proprietà";
        }
        for (y = 0; y < 21; y++)
        {
            arr2[y] = "Nessuna Proprietà";
        }

        i = 0;
        y = 0;

        b1.SetActive(true);
        b2.SetActive(true);
    }

    public void rifiuta()
    {
        b1.SetActive(true);
        b2.SetActive(true);

        for (i = 0; i < 21; i++)
        {
            arr1[i] = "Nessuna Proprietà";
        }

        for (y = 0; y < 21; y++)
        {
            arr2[y] = "Nessuna Proprietà";
        }

        i = 0;
        y = 0;

        GameObject.Find("TRATTATIVA").SetActive(false);
    }

    public void reset()
    {
        for (int r = 0; r < 21; r++)
        {
            array1[r].text = "Nessuna Proprietà";
        }
        for (int r = 0; r < 21; r++)
        {
            array2[r].text = "Nessuna Proprietà";
        }
    }
}

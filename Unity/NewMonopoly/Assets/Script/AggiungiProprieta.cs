using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AggiungiProprieta : MonoBehaviour
{
    // public int player;
    public GameObject sv1;
    public GameObject sv2;
    //public List<string> NameList = new List<string>();

    private string[] arr1 = new string[21];
    private string[] arr2 = new string[21];

    private int i = 0;
    private int y = 0;

    public Text prova;
    public Text prova1;

    public Text Prop1_Player1;
    public Text Prop2_Player1;
    public Text Prop3_Player1;
    public Text Prop4_Player1;
    public Text Prop5_Player1;
    public Text Prop6_Player1;
    public Text Prop7_Player1;
    public Text Prop8_Player1;
    public Text Prop9_Player1;
    public Text Prop10_Player1;
    public Text Prop11_Player1;
    public Text Prop12_Player1;
    public Text Prop13_Player1;
    public Text Prop14_Player1;
    public Text Prop15_Player1;
    public Text Prop16_Player1;
    public Text Prop17_Player1;
    public Text Prop18_Player1;
    public Text Prop19_Player1;
    public Text Prop20_Player1;
    public Text Prop21_Player1;
    //----------------------------
    public Text Prop1_Player2;
    public Text Prop2_Player2;
    public Text Prop3_Player2;
    public Text Prop4_Player2;
    public Text Prop5_Player2;
    public Text Prop6_Player2;
    public Text Prop7_Player2;
    public Text Prop8_Player2;
    public Text Prop9_Player2;
    public Text Prop10_Player2;
    public Text Prop11_Player2;
    public Text Prop12_Player2;
    public Text Prop13_Player2;
    public Text Prop14_Player2;
    public Text Prop15_Player2;
    public Text Prop16_Player2;
    public Text Prop17_Player2;
    public Text Prop18_Player2;
    public Text Prop19_Player2;
    public Text Prop20_Player2;
    public Text Prop21_Player2;

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

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPropieta1()
    {

        /* for (int p = 0; p < 21; p++)
         {
             if (p1.proprieta[p] == null)
                 p1.proprieta[p].nomeCasella = "Nessuna Proprietà";
             if (p2.proprieta[p] == null)
                 p2.proprieta[p].nomeCasella = "Nessuna Proprietà";
             if (p3.proprieta[p] == null)
                 p3.proprieta[p].nomeCasella = "Nessuna Proprietà";
             if (p4.proprieta[p] == null)
                 p4.proprieta[p].nomeCasella = "Nessuna Proprietà";
             if (p5.proprieta[p] == null)
                 p5.proprieta[p].nomeCasella = "Nessuna Proprietà";
             if (p6.proprieta[p] == null)
                 p6.proprieta[p].nomeCasella = "Nessuna Proprietà";
         }*/
        b1.active = false;
        //sv1.active = true;
        //List<Proprietà> listaproprietà = //lista proprietà player attivo 
        /*  for(int i = 0; i<= 21; i++)
          {
              if (p1.proprieta[i] == null)
                  p1.proprieta[i].nomeCasella = "nessuna proprietà";
          }*/

        if (p1.attivo == true)
        {
            // Prop1_Player1.text = "Proprietà 1"; //Lista[0];
            Prop1_Player1.text = p1.proprieta[0].nomeCasella;
            Prop2_Player1.text = p1.proprieta[1].nomeCasella;
            Prop3_Player1.text = p1.proprieta[2].nomeCasella;
            Prop4_Player1.text = p1.proprieta[3].nomeCasella;
            Prop5_Player1.text = p1.proprieta[4].nomeCasella;
            Prop6_Player1.text = p1.proprieta[5].nomeCasella;
            Prop7_Player1.text = p1.proprieta[6].nomeCasella;
            Prop8_Player1.text = p1.proprieta[7].nomeCasella;
            Prop9_Player1.text = p1.proprieta[8].nomeCasella;
            Prop10_Player1.text = p1.proprieta[9].nomeCasella;
            Prop11_Player1.text = p1.proprieta[10].nomeCasella;
            Prop12_Player1.text = p1.proprieta[11].nomeCasella;
            Prop13_Player1.text = p1.proprieta[12].nomeCasella;
            Prop14_Player1.text = p1.proprieta[13].nomeCasella;
            Prop15_Player1.text = p1.proprieta[14].nomeCasella;
            Prop16_Player1.text = p1.proprieta[15].nomeCasella;
            Prop17_Player1.text = p1.proprieta[16].nomeCasella;
            Prop18_Player1.text = p1.proprieta[17].nomeCasella;
            Prop19_Player1.text = p1.proprieta[18].nomeCasella;
            Prop20_Player1.text = p1.proprieta[19].nomeCasella;
            Prop21_Player1.text = p1.proprieta[20].nomeCasella;
        }
        else if (p2.attivo == true)
        {
            Prop1_Player1.text = p2.proprieta[0].nomeCasella;
            Prop2_Player1.text = p2.proprieta[1].nomeCasella;
            Prop3_Player1.text = p2.proprieta[2].nomeCasella;
            Prop4_Player1.text = p2.proprieta[3].nomeCasella;
            Prop5_Player1.text = p2.proprieta[4].nomeCasella;
            Prop6_Player1.text = p2.proprieta[5].nomeCasella;
            Prop7_Player1.text = p2.proprieta[6].nomeCasella;
            Prop8_Player1.text = p2.proprieta[7].nomeCasella;
            Prop9_Player1.text = p2.proprieta[8].nomeCasella;
            Prop10_Player1.text = p2.proprieta[9].nomeCasella;
            Prop11_Player1.text = p2.proprieta[10].nomeCasella;
            Prop12_Player1.text = p2.proprieta[11].nomeCasella;
            Prop13_Player1.text = p2.proprieta[12].nomeCasella;
            Prop14_Player1.text = p2.proprieta[13].nomeCasella;
            Prop15_Player1.text = p2.proprieta[14].nomeCasella;
            Prop16_Player1.text = p2.proprieta[15].nomeCasella;
            Prop17_Player1.text = p2.proprieta[16].nomeCasella;
            Prop18_Player1.text = p2.proprieta[17].nomeCasella;
            Prop19_Player1.text = p2.proprieta[18].nomeCasella;
            Prop20_Player1.text = p2.proprieta[19].nomeCasella;
            Prop21_Player1.text = p2.proprieta[20].nomeCasella;
        }
        else if (p3.attivo == true)
        {
            Prop1_Player1.text = p3.proprieta[0].nomeCasella;
            Prop2_Player1.text = p3.proprieta[1].nomeCasella;
            Prop3_Player1.text = p3.proprieta[2].nomeCasella;
            Prop4_Player1.text = p3.proprieta[3].nomeCasella;
            Prop5_Player1.text = p3.proprieta[4].nomeCasella;
            Prop6_Player1.text = p3.proprieta[5].nomeCasella;
            Prop7_Player1.text = p3.proprieta[6].nomeCasella;
            Prop8_Player1.text = p3.proprieta[7].nomeCasella;
            Prop9_Player1.text = p3.proprieta[8].nomeCasella;
            Prop10_Player1.text = p3.proprieta[9].nomeCasella;
            Prop11_Player1.text = p3.proprieta[10].nomeCasella;
            Prop12_Player1.text = p3.proprieta[11].nomeCasella;
            Prop13_Player1.text = p3.proprieta[12].nomeCasella;
            Prop14_Player1.text = p3.proprieta[13].nomeCasella;
            Prop15_Player1.text = p3.proprieta[14].nomeCasella;
            Prop16_Player1.text = p3.proprieta[15].nomeCasella;
            Prop17_Player1.text = p3.proprieta[16].nomeCasella;
            Prop18_Player1.text = p3.proprieta[17].nomeCasella;
            Prop19_Player1.text = p3.proprieta[18].nomeCasella;
            Prop20_Player1.text = p3.proprieta[19].nomeCasella;
            Prop21_Player1.text = p3.proprieta[20].nomeCasella;
        }
        else if (p4.attivo == true)
        {
            Prop1_Player1.text = p4.proprieta[0].nomeCasella;
            Prop2_Player1.text = p4.proprieta[1].nomeCasella;
            Prop3_Player1.text = p4.proprieta[2].nomeCasella;
            Prop4_Player1.text = p4.proprieta[3].nomeCasella;
            Prop5_Player1.text = p4.proprieta[4].nomeCasella;
            Prop6_Player1.text = p4.proprieta[5].nomeCasella;
            Prop7_Player1.text = p4.proprieta[6].nomeCasella;
            Prop8_Player1.text = p4.proprieta[7].nomeCasella;
            Prop9_Player1.text = p4.proprieta[8].nomeCasella;
            Prop10_Player1.text = p4.proprieta[9].nomeCasella;
            Prop11_Player1.text = p4.proprieta[10].nomeCasella;
            Prop12_Player1.text = p4.proprieta[11].nomeCasella;
            Prop13_Player1.text = p4.proprieta[12].nomeCasella;
            Prop14_Player1.text = p4.proprieta[13].nomeCasella;
            Prop15_Player1.text = p4.proprieta[14].nomeCasella;
            Prop16_Player1.text = p4.proprieta[15].nomeCasella;
            Prop17_Player1.text = p4.proprieta[16].nomeCasella;
            Prop18_Player1.text = p4.proprieta[17].nomeCasella;
            Prop19_Player1.text = p4.proprieta[18].nomeCasella;
            Prop20_Player1.text = p4.proprieta[19].nomeCasella;
            Prop21_Player1.text = p4.proprieta[20].nomeCasella;
        }
        else if (p5.attivo == true)
        {
            Prop1_Player1.text = p5.proprieta[0].nomeCasella;
            Prop2_Player1.text = p5.proprieta[1].nomeCasella;
            Prop3_Player1.text = p5.proprieta[2].nomeCasella;
            Prop4_Player1.text = p5.proprieta[3].nomeCasella;
            Prop5_Player1.text = p5.proprieta[4].nomeCasella;
            Prop6_Player1.text = p5.proprieta[5].nomeCasella;
            Prop7_Player1.text = p5.proprieta[6].nomeCasella;
            Prop8_Player1.text = p5.proprieta[7].nomeCasella;
            Prop9_Player1.text = p5.proprieta[8].nomeCasella;
            Prop10_Player1.text = p5.proprieta[9].nomeCasella;
            Prop11_Player1.text = p5.proprieta[10].nomeCasella;
            Prop12_Player1.text = p5.proprieta[11].nomeCasella;
            Prop13_Player1.text = p5.proprieta[12].nomeCasella;
            Prop14_Player1.text = p5.proprieta[13].nomeCasella;
            Prop15_Player1.text = p5.proprieta[14].nomeCasella;
            Prop16_Player1.text = p5.proprieta[15].nomeCasella;
            Prop17_Player1.text = p5.proprieta[16].nomeCasella;
            Prop18_Player1.text = p5.proprieta[17].nomeCasella;
            Prop19_Player1.text = p5.proprieta[18].nomeCasella;
            Prop20_Player1.text = p5.proprieta[19].nomeCasella;
            Prop21_Player1.text = p5.proprieta[20].nomeCasella;
        }
        else if (p6.attivo == true)
        {
            Prop1_Player1.text = p6.proprieta[0].nomeCasella;
            Prop2_Player1.text = p6.proprieta[1].nomeCasella;
            Prop3_Player1.text = p6.proprieta[2].nomeCasella;
            Prop4_Player1.text = p6.proprieta[3].nomeCasella;
            Prop5_Player1.text = p6.proprieta[4].nomeCasella;
            Prop6_Player1.text = p6.proprieta[5].nomeCasella;
            Prop7_Player1.text = p6.proprieta[6].nomeCasella;
            Prop8_Player1.text = p6.proprieta[7].nomeCasella;
            Prop9_Player1.text = p6.proprieta[8].nomeCasella;
            Prop10_Player1.text = p6.proprieta[9].nomeCasella;
            Prop11_Player1.text = p6.proprieta[10].nomeCasella;
            Prop12_Player1.text = p6.proprieta[11].nomeCasella;
            Prop13_Player1.text = p6.proprieta[12].nomeCasella;
            Prop14_Player1.text = p6.proprieta[13].nomeCasella;
            Prop15_Player1.text = p6.proprieta[14].nomeCasella;
            Prop16_Player1.text = p6.proprieta[15].nomeCasella;
            Prop17_Player1.text = p6.proprieta[16].nomeCasella;
            Prop18_Player1.text = p6.proprieta[17].nomeCasella;
            Prop19_Player1.text = p6.proprieta[18].nomeCasella;
            Prop20_Player1.text = p6.proprieta[19].nomeCasella;
            Prop21_Player1.text = p6.proprieta[20].nomeCasella;
        }


    }

    public void AddPropieta2()
    {
        b2.active = false;
        //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 1"))
        //if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa1"))


        if (Player2.text.Equals("Player 1"))
        {
            //Prop2_Player2.text = "Proprietà 1";
            Prop1_Player2.text = p1.proprieta[0].nomeCasella;
            Prop2_Player2.text = p1.proprieta[1].nomeCasella;
            Prop3_Player2.text = p1.proprieta[2].nomeCasella;
            Prop4_Player2.text = p1.proprieta[3].nomeCasella;
            Prop5_Player2.text = p1.proprieta[4].nomeCasella;
            Prop6_Player2.text = p1.proprieta[5].nomeCasella;
            Prop7_Player2.text = p1.proprieta[6].nomeCasella;
            Prop8_Player2.text = p1.proprieta[7].nomeCasella;
            Prop9_Player2.text = p1.proprieta[8].nomeCasella;
            Prop10_Player2.text = p1.proprieta[9].nomeCasella;
            Prop11_Player2.text = p1.proprieta[10].nomeCasella;
            Prop12_Player2.text = p1.proprieta[11].nomeCasella;
            Prop13_Player2.text = p1.proprieta[12].nomeCasella;
            Prop14_Player2.text = p1.proprieta[13].nomeCasella;
            Prop15_Player2.text = p1.proprieta[14].nomeCasella;
            Prop16_Player2.text = p1.proprieta[15].nomeCasella;
            Prop17_Player2.text = p1.proprieta[16].nomeCasella;
            Prop18_Player2.text = p1.proprieta[17].nomeCasella;
            Prop19_Player2.text = p1.proprieta[18].nomeCasella;
            Prop20_Player2.text = p1.proprieta[19].nomeCasella;
            Prop21_Player2.text = p1.proprieta[20].nomeCasella;
        }
        //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 2"))
        //if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa2"))
        if (Player2.text.Equals("Player 2"))
        {
            //Prop2_Player2.text = "Proprietà 1";
            Prop1_Player2.text = p2.proprieta[0].nomeCasella;
            Prop2_Player2.text = p2.proprieta[1].nomeCasella;
            Prop3_Player2.text = p2.proprieta[2].nomeCasella;
            Prop4_Player2.text = p2.proprieta[3].nomeCasella;
            Prop5_Player2.text = p2.proprieta[4].nomeCasella;
            Prop6_Player2.text = p2.proprieta[5].nomeCasella;
            Prop7_Player2.text = p2.proprieta[6].nomeCasella;
            Prop8_Player2.text = p2.proprieta[7].nomeCasella;
            Prop9_Player2.text = p2.proprieta[8].nomeCasella;
            Prop10_Player2.text = p2.proprieta[9].nomeCasella;
            Prop11_Player2.text = p2.proprieta[10].nomeCasella;
            Prop12_Player2.text = p2.proprieta[11].nomeCasella;
            Prop13_Player2.text = p2.proprieta[12].nomeCasella;
            Prop14_Player2.text = p2.proprieta[13].nomeCasella;
            Prop15_Player2.text = p2.proprieta[14].nomeCasella;
            Prop16_Player2.text = p2.proprieta[15].nomeCasella;
            Prop17_Player2.text = p2.proprieta[16].nomeCasella;
            Prop18_Player2.text = p2.proprieta[17].nomeCasella;
            Prop19_Player2.text = p2.proprieta[18].nomeCasella;
            Prop20_Player2.text = p2.proprieta[19].nomeCasella;
            Prop21_Player2.text = p2.proprieta[20].nomeCasella;
        }
        //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 3"))
        //if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa3"))
        if (Player2.text.Equals("Player 3"))
        {
            //Prop2_Player2.text = "Proprietà 1";
            Prop1_Player2.text = p3.proprieta[0].nomeCasella;
            Prop2_Player2.text = p3.proprieta[1].nomeCasella;
            Prop3_Player2.text = p3.proprieta[2].nomeCasella;
            Prop4_Player2.text = p3.proprieta[3].nomeCasella;
            Prop5_Player2.text = p3.proprieta[4].nomeCasella;
            Prop6_Player2.text = p3.proprieta[5].nomeCasella;
            Prop7_Player2.text = p3.proprieta[6].nomeCasella;
            Prop8_Player2.text = p3.proprieta[7].nomeCasella;
            Prop9_Player2.text = p3.proprieta[8].nomeCasella;
            Prop10_Player2.text = p3.proprieta[9].nomeCasella;
            Prop11_Player2.text = p3.proprieta[10].nomeCasella;
            Prop12_Player2.text = p3.proprieta[11].nomeCasella;
            Prop13_Player2.text = p3.proprieta[12].nomeCasella;
            Prop14_Player2.text = p3.proprieta[13].nomeCasella;
            Prop15_Player2.text = p3.proprieta[14].nomeCasella;
            Prop16_Player2.text = p3.proprieta[15].nomeCasella;
            Prop17_Player2.text = p3.proprieta[16].nomeCasella;
            Prop18_Player2.text = p3.proprieta[17].nomeCasella;
            Prop19_Player2.text = p3.proprieta[18].nomeCasella;
            Prop20_Player2.text = p3.proprieta[19].nomeCasella;
            Prop21_Player2.text = p3.proprieta[20].nomeCasella;
        }
        //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 4"))
        //if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa4"))
        if (Player2.text.Equals("Player 4"))
        {
            //Prop2_Player2.text = "Proprietà 1";
            Prop1_Player2.text = p4.proprieta[0].nomeCasella;
            Prop2_Player2.text = p4.proprieta[1].nomeCasella;
            Prop3_Player2.text = p4.proprieta[2].nomeCasella;
            Prop4_Player2.text = p4.proprieta[3].nomeCasella;
            Prop5_Player2.text = p4.proprieta[4].nomeCasella;
            Prop6_Player2.text = p4.proprieta[5].nomeCasella;
            Prop7_Player2.text = p4.proprieta[6].nomeCasella;
            Prop8_Player2.text = p4.proprieta[7].nomeCasella;
            Prop9_Player2.text = p4.proprieta[8].nomeCasella;
            Prop10_Player2.text = p4.proprieta[9].nomeCasella;
            Prop11_Player2.text = p4.proprieta[10].nomeCasella;
            Prop12_Player2.text = p4.proprieta[11].nomeCasella;
            Prop13_Player2.text = p4.proprieta[12].nomeCasella;
            Prop14_Player2.text = p4.proprieta[13].nomeCasella;
            Prop15_Player2.text = p4.proprieta[14].nomeCasella;
            Prop16_Player2.text = p4.proprieta[15].nomeCasella;
            Prop17_Player2.text = p4.proprieta[16].nomeCasella;
            Prop18_Player2.text = p4.proprieta[17].nomeCasella;
            Prop19_Player2.text = p4.proprieta[18].nomeCasella;
            Prop20_Player2.text = p4.proprieta[19].nomeCasella;
            Prop21_Player2.text = p4.proprieta[20].nomeCasella;
        }
        //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 5"))
        //if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa5"))
        if (Player2.text.Equals("Player 5"))
        {
            //Prop2_Player2.text = "Proprietà 1";
            Prop1_Player2.text = p5.proprieta[0].nomeCasella;
            Prop2_Player2.text = p5.proprieta[1].nomeCasella;
            Prop3_Player2.text = p5.proprieta[2].nomeCasella;
            Prop4_Player2.text = p5.proprieta[3].nomeCasella;
            Prop5_Player2.text = p5.proprieta[4].nomeCasella;
            Prop6_Player2.text = p5.proprieta[5].nomeCasella;
            Prop7_Player2.text = p5.proprieta[6].nomeCasella;
            Prop8_Player2.text = p5.proprieta[7].nomeCasella;
            Prop9_Player2.text = p5.proprieta[8].nomeCasella;
            Prop10_Player2.text = p5.proprieta[9].nomeCasella;
            Prop11_Player2.text = p5.proprieta[10].nomeCasella;
            Prop12_Player2.text = p5.proprieta[11].nomeCasella;
            Prop13_Player2.text = p5.proprieta[12].nomeCasella;
            Prop14_Player2.text = p5.proprieta[13].nomeCasella;
            Prop15_Player2.text = p5.proprieta[14].nomeCasella;
            Prop16_Player2.text = p5.proprieta[15].nomeCasella;
            Prop17_Player2.text = p5.proprieta[16].nomeCasella;
            Prop18_Player2.text = p5.proprieta[17].nomeCasella;
            Prop19_Player2.text = p5.proprieta[18].nomeCasella;
            Prop20_Player2.text = p5.proprieta[19].nomeCasella;
            Prop21_Player2.text = p5.proprieta[20].nomeCasella;
        }
        //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 6"))
        //if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa1"))
        if (Player2.text.Equals("Player 6"))
        {
            //Prop2_Player2.text = "Proprietà 1";
            Prop1_Player2.text = p6.proprieta[0].nomeCasella;
            Prop2_Player2.text = p6.proprieta[1].nomeCasella;
            Prop3_Player2.text = p6.proprieta[2].nomeCasella;
            Prop4_Player2.text = p6.proprieta[3].nomeCasella;
            Prop5_Player2.text = p6.proprieta[4].nomeCasella;
            Prop6_Player2.text = p6.proprieta[5].nomeCasella;
            Prop7_Player2.text = p6.proprieta[6].nomeCasella;
            Prop8_Player2.text = p6.proprieta[7].nomeCasella;
            Prop9_Player2.text = p6.proprieta[8].nomeCasella;
            Prop10_Player2.text = p6.proprieta[9].nomeCasella;
            Prop11_Player2.text = p6.proprieta[10].nomeCasella;
            Prop12_Player2.text = p6.proprieta[11].nomeCasella;
            Prop13_Player2.text = p6.proprieta[12].nomeCasella;
            Prop14_Player2.text = p6.proprieta[13].nomeCasella;
            Prop15_Player2.text = p6.proprieta[14].nomeCasella;
            Prop16_Player2.text = p6.proprieta[15].nomeCasella;
            Prop17_Player2.text = p6.proprieta[16].nomeCasella;
            Prop18_Player2.text = p6.proprieta[17].nomeCasella;
            Prop19_Player2.text = p6.proprieta[18].nomeCasella;
            Prop20_Player2.text = p6.proprieta[19].nomeCasella;
            Prop21_Player2.text = p6.proprieta[20].nomeCasella;
        }


    }

    public void annulla1()
    {
        sv1.active = false;

    }

    public void annulla2()
    {

        sv2.active = false;
    }

    public void scegli1()
    {
        //EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
        arr1[i] = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        i++;
        prova.text = arr1[0];
    }

    public void scegli2()
    {
        //EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
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
                //Debug.Log(arr1[z]);
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
                    //-------------------------------//
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

                    //------------------//
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
                        //-------------------------------//
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

        b1.active = true;
        b2.active = true;

    }
   

    public void rifiuta()
    {
        b1.active = true;
        b2.active = true;

        
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

        GameObject.Find("TRATTATIVA").active = false;

    }

    public void reset()
    {
        Prop1_Player1.text = "Nessuna Proprietà";
        Prop2_Player1.text = "Nessuna Proprietà";
        Prop3_Player1.text = "Nessuna Proprietà";
        Prop4_Player1.text = "Nessuna Proprietà";
        Prop5_Player1.text = "Nessuna Proprietà";
        Prop6_Player1.text = "Nessuna Proprietà";
        Prop7_Player1.text = "Nessuna Proprietà";
        Prop8_Player1.text = "Nessuna Proprietà";
        Prop9_Player1.text = "Nessuna Proprietà";
        Prop10_Player1.text = "Nessuna Proprietà";
        Prop11_Player1.text = "Nessuna Proprietà";
        Prop12_Player1.text = "Nessuna Proprietà";
        Prop13_Player1.text = "Nessuna Proprietà";
        Prop14_Player1.text = "Nessuna Proprietà";
        Prop15_Player1.text = "Nessuna Proprietà";
        Prop16_Player1.text = "Nessuna Proprietà";
        Prop17_Player1.text = "Nessuna Proprietà";
        Prop18_Player1.text = "Nessuna Proprietà";
        Prop19_Player1.text = "Nessuna Proprietà";
        Prop20_Player1.text = "Nessuna Proprietà";
        Prop21_Player1.text = "Nessuna Proprietà";

        Prop1_Player2.text = "Nessuna Proprietà";
        Prop2_Player2.text = "Nessuna Proprietà";
        Prop3_Player2.text = "Nessuna Proprietà";
        Prop4_Player2.text = "Nessuna Proprietà";
        Prop5_Player2.text = "Nessuna Proprietà";
        Prop6_Player2.text = "Nessuna Proprietà";
        Prop7_Player2.text = "Nessuna Proprietà";
        Prop8_Player2.text = "Nessuna Proprietà";
        Prop9_Player2.text = "Nessuna Proprietà";
        Prop10_Player2.text = "Nessuna Proprietà";
        Prop11_Player2.text = "Nessuna Proprietà";
        Prop12_Player2.text = "Nessuna Proprietà";
        Prop13_Player2.text = "Nessuna Proprietà";
        Prop14_Player2.text = "Nessuna Proprietà";
        Prop15_Player2.text = "Nessuna Proprietà";
        Prop16_Player2.text = "Nessuna Proprietà";
        Prop17_Player2.text = "Nessuna Proprietà";
        Prop18_Player2.text = "Nessuna Proprietà";
        Prop19_Player2.text = "Nessuna Proprietà";
        Prop20_Player2.text = "Nessuna Proprietà";
        Prop21_Player2.text = "Nessuna Proprietà";
    }
}

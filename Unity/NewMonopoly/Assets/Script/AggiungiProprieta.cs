using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AggiungiProprieta : MonoBehaviour {
   // public int player;
    public GameObject sv1;
    public GameObject sv2;
    //public List<string> NameList = new List<string>();

    private string[] arr1 = new string[21];
    private string[] arr2 = new string[21];

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

    public StateController sc;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddPropieta1()
    {
        b1.active = false;
        //sv1.active = true;
        //List<Proprietà> listaproprietà = //lista proprietà player attivo 
        Prop1_Player1.text = "Proprietà 1"; //Lista[0];
        Prop2_Player1.text = "Proprietà 2";
        Prop3_Player1.text = "Proprietà 3";
        Prop4_Player1.text = "Proprietà 4";
        Prop5_Player1.text = "Proprietà 5";
        Prop6_Player1.text = "Proprietà 6";
        Prop7_Player1.text = "Proprietà 7";
        Prop8_Player1.text = "Proprietà 8";
        Prop9_Player1.text = "Proprietà 9";
        Prop10_Player1.text = "Proprietà 10";
        Prop11_Player1.text = "Proprietà 11";
        Prop12_Player1.text = "Proprietà 12";
        Prop13_Player1.text = "Proprietà 13";
        Prop14_Player1.text = "Proprietà 14";
        Prop15_Player1.text = "Proprietà 15";
        Prop16_Player1.text = "Proprietà 16";
        Prop17_Player1.text = "Proprietà 17";
        Prop18_Player1.text = "Proprietà 18";
        Prop19_Player1.text = "Proprietà 19";
        Prop20_Player1.text = "Proprietà 20";
        Prop21_Player1.text = "Proprietà 21";

    }

    public void AddPropieta2()
    {
        b2.active = false;
        if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 1"))
        {
            
            //Prop1_Player2.text = p1.proprieta[0];
            Prop2_Player2.text = "Proprietà 2";
            Prop3_Player2.text = "Proprietà 3";
            Prop4_Player2.text = "Proprietà 4";
            Prop5_Player2.text = "Proprietà 5";
            Prop6_Player2.text = "Proprietà 6";
            Prop7_Player2.text = "Proprietà 7";
            Prop8_Player2.text = "Proprietà 8";
            Prop9_Player2.text = "Proprietà 9";
            Prop10_Player2.text = "Proprietà 10";
            Prop11_Player2.text = "Proprietà 11";
            Prop12_Player2.text = "Proprietà 12";
            Prop13_Player2.text = "Proprietà 13";
            Prop14_Player2.text = "Proprietà 14";
            Prop15_Player2.text = "Proprietà 15";
            Prop16_Player2.text = "Proprietà 16";
            Prop17_Player2.text = "Proprietà 17";
            Prop18_Player2.text = "Proprietà 18";
            Prop19_Player2.text = "Proprietà 19";
            Prop20_Player2.text = "Proprietà 20";
            Prop21_Player2.text = "Proprietà 21";
        }

        //do something
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
        
        int i = 0;
        arr1[i] = EventSystem.current.currentSelectedGameObject.GetComponent<Text>().text;
        i++;
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
    }

    public void scegli2()
    {

        int i = 0;
        arr2[i] = EventSystem.current.currentSelectedGameObject.GetComponent<Text>().text;
        i++;
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
    }

    public void rifiuta()
    {
        b1.active = true;
        b2.active = true;
        GameObject.Find("TRATTATIVA").active = false;
        
    }
}

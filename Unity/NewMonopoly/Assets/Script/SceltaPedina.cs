using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceltaPedina : MonoBehaviour {
	
    public int contatoregiocatori = 0;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void numgiocatori()
    {
        contatoregiocatori++;
        GameObject.Find("Numero").GetComponent<Text>().text = contatoregiocatori.ToString();
        //this.gameObject.interactable = false;
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
        StateController.giocatoriSelezionati = contatoregiocatori;
    }
}

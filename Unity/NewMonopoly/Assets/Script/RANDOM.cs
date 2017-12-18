using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RANDOM : MonoBehaviour {

    public Text[] text;
    public int risultato = 0; // Ogni volta che si tira si azzera il punteggio dei dadi

    // Use this for initialization
    void Start () {

		text[0].text = UnityEngine.Random.Range(1, 6).ToString();
        text[1].text = UnityEngine.Random.Range(1, 6).ToString();
        risultato = int.Parse(text[0].text + text[1].text);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ok()
    {
        SceneManager.UnloadScene(3);
        SceneManager.LoadScene(2);
    }
}

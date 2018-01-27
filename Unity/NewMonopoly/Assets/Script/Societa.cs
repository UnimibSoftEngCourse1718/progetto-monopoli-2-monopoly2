using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Societa : Casella
{
    //se si possiede solo una società il pedaggio è pari a 4 volte il tiro del dado
    //se si possiedono due società il pedaggio è pari a 10 volte il tiro del dado
    public int costo = 150;
    public int ipoteca = 75;
    public Giocatore proprietario;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

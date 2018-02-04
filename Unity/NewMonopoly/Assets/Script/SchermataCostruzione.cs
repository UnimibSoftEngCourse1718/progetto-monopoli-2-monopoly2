using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SchermataCostruzione : MonoBehaviour
{
    public Terreno terreno { get; set; }
    public GameObject schermata;
    giocatore giocatoreDiturno;
    int[] colori = new int[8];
    Button[] listaPulsanti;
    List<Terreno> listaTerreni = new List<Terreno>();

    public void Visualizza()
    {
        giocatoreDiturno = GameObject.FindObjectOfType<StateController>().getGiocatoreAttivo();

        foreach (CasellaAcquistabile item in giocatoreDiturno.proprieta)
        {
            if (item.nomeCasella == "TERAMO" || item.nomeCasella == "SANREMO")
                colori[0]++;
            else if (item.nomeCasella == "L'AQUILA" || item.nomeCasella == "TRANI" || item.nomeCasella == "TORINO")
                colori[1]++;
            else if (item.nomeCasella == "COSENZA" || item.nomeCasella == "MILANO" || item.nomeCasella == "VIAREGGIO")
                colori[2]++;
            else if (item.nomeCasella == "TERNI" || item.nomeCasella == "MESSINA" || item.nomeCasella == "FOGGIA")
                colori[3]++;
            else if (item.nomeCasella == "CASERTA" || item.nomeCasella == "BRINDISI" || item.nomeCasella == "ISCHIA")
                colori[4]++;
            else if (item.nomeCasella == "MONOPOLI" || item.nomeCasella == "ASCOLI PICENO" || item.nomeCasella == "ISOLA D'ELBA")
                colori[5]++;
            else if (item.nomeCasella == "ANDRIA" || item.nomeCasella == "BARLETTA" || item.nomeCasella == "CATANZARO")
                colori[6]++;
            else if (item.nomeCasella == "REGGIO CALABRIA" || item.nomeCasella == "CHIETI")
                colori[7]++;
            /*
            // Togliere il commento per poter costruire ovunque
            if (item as Terreno != null)
            {
                listaTerreni.Add(item as Terreno);
            }*/
        }
        
        foreach (CasellaAcquistabile item in giocatoreDiturno.proprieta)
        {
            if (colori[0] == 2 && (item.nomeCasella == "TERAMO" || item.nomeCasella == "SANREMO"))
                listaTerreni.Add(item as Terreno);
            else if (colori[1] == 3 && (item.nomeCasella == "L'AQUILA" || item.nomeCasella == "TRANI" || item.nomeCasella == "TORINO"))
                listaTerreni.Add(item as Terreno);
            else if (colori[2] == 3 && (item.nomeCasella == "COSENZA" || item.nomeCasella == "MILANO" || item.nomeCasella == "VIAREGGIO"))
                listaTerreni.Add(item as Terreno);
            else if (colori[3] == 3 && (item.nomeCasella == "TERNI" || item.nomeCasella == "MESSINA" || item.nomeCasella == "FOGGIA"))
                listaTerreni.Add(item as Terreno);
            else if (colori[4] == 3 && (item.nomeCasella == "CASERTA" || item.nomeCasella == "BRINDISI" || item.nomeCasella == "ISCHIA"))
                listaTerreni.Add(item as Terreno);
            else if (colori[5] == 3 && (item.nomeCasella == "MONOPOLI" || item.nomeCasella == "ASCOLI PICENO" || item.nomeCasella == "ISOLA D'ELBA"))
                listaTerreni.Add(item as Terreno);
            else if (colori[6] == 3 && (item.nomeCasella == "ANDRIA" || item.nomeCasella == "BARLETTA" || item.nomeCasella == "CATANZARO"))
                listaTerreni.Add(item as Terreno);
            else if (colori[7] == 2 && (item.nomeCasella == "REGGIO CALABRIA" || item.nomeCasella == "CHIETI"))
                listaTerreni.Add(item as Terreno);
        }

        giocatoreDiturno.controller.DisattivaPulsantiFineTurno();
        schermata.SetActive(true);

        listaPulsanti = GameObject.Find("ScrollPulsanti").GetComponentsInChildren<Button>();
        for (int i = listaPulsanti.Length - 1; i >= listaTerreni.Count; i--)
            listaPulsanti[i].gameObject.SetActive(false);

        Terreno[] supporto = listaTerreni.ToArray();
        for (int i = 0; i < supporto.Length; i++)
            listaPulsanti[i].GetComponentInChildren<Text>().text = supporto[i].nomeCasella;

        int altezza = listaTerreni.Count * 55 - 5;
        GameObject.Find("ScrollPulsanti").GetComponent<RectTransform>().sizeDelta = new Vector2(0, altezza);
    }

    public void PulsanteCostruisci()
    {
        string nomeTerreno = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().GetComponentInChildren<Text>().text;

        foreach (Terreno item in GameObject.FindObjectsOfType<Terreno>())
            if (item.nomeCasella == nomeTerreno)
                terreno = item;

        if (terreno != null && terreno.costoEdificio <= giocatoreDiturno.soldi)
        {
            if (giocatoreDiturno.soldi - terreno.costoEdificio >= 0 && terreno.nEdifici < 5)
            {
                giocatoreDiturno.TrasferimentoDenaro(-terreno.costoEdificio);
                terreno.CostruzioneEdificio();
            }
        }

        PulsanteAnnulla();
    }

    public void PulsanteAnnulla()
    {
        giocatoreDiturno.controller.AttivaPulsantiFineTurno();
        this.giocatoreDiturno = null;
        listaTerreni = new List<Terreno>();
        terreno = null;
        colori = new int[8];

        GameObject.Find("ScrollPulsanti").SetActiveRecursively(true);
        listaPulsanti = GameObject.Find("ScrollPulsanti").GetComponentsInChildren<Button>();

        for (int i = 0; i < listaPulsanti.Length; i++)
            listaPulsanti[i].GetComponentInChildren<Text>().text = "PROPRIETÀ";

        schermata.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SchermataCostruzione : MonoBehaviour
{
    public Terreno terreno;
    public GameObject schermata;
    private giocatore giocatoreDiturno;
    private int marrone = 0, azzurro = 0, rosa = 0, arancione = 0, rosso = 0, giallo = 0, verde = 0, blu = 0;
    private Button[] listaPulsanti;
    List<Terreno> listaTerreni = new List<Terreno>();

    public void Visualizza()
    {
        // Trovo il giocatore attivo
        foreach (giocatore item in GameObject.FindObjectsOfType<giocatore>())
            if (item.attivo)
                giocatoreDiturno = item;

        foreach (CasellaAcquistabile item in giocatoreDiturno.proprieta)
        {
            if (item.nomeCasella == "TERAMO" || item.nomeCasella == "SANREMO")
                marrone++;
            else if (item.nomeCasella == "L'AQUILA" || item.nomeCasella == "TRANI" || item.nomeCasella == "TORINO")
                azzurro++;
            else if (item.nomeCasella == "COSENZA" || item.nomeCasella == "MILANO" || item.nomeCasella == "VIAREGGIO")
                rosa++;
            else if (item.nomeCasella == "TERNI" || item.nomeCasella == "MESSINA" || item.nomeCasella == "FOGGIA")
                arancione++;
            else if (item.nomeCasella == "CASERTA" || item.nomeCasella == "BRINDISI" || item.nomeCasella == "ISCHIA")
                rosso++;
            else if (item.nomeCasella == "MONOPOLI" || item.nomeCasella == "ASCOLI PICENO" || item.nomeCasella == "ISOLA D'ELBA")
                giallo++;
            else if (item.nomeCasella == "ANDRIA" || item.nomeCasella == "BARLETTA" || item.nomeCasella == "CATANZARO")
                verde++;
            else if (item.nomeCasella == "REGGIO CALABRIA" || item.nomeCasella == "CHIETI")
                blu++;
            if (item as Terreno != null)
            {
                listaTerreni.Add(item as Terreno);
            }
        }
        /*
        foreach (CasellaAcquistabile item in giocatoreDiturno.proprieta)
        {
            if (marrone == 2 && item.nomeCasella == "TERAMO" || item.nomeCasella == "SANREMO")
                listaTerreni.Add(item as Terreno);
            else if (azzurro == 3 && item.nomeCasella == "L'AQUILA" || item.nomeCasella == "TRANI" || item.nomeCasella == "TORINO")
                listaTerreni.Add(item as Terreno);
            else if (rosa == 3 && item.nomeCasella == "COSENZA" || item.nomeCasella == "MILANO" || item.nomeCasella == "VIAREGGIO")
                listaTerreni.Add(item as Terreno);
            else if (arancione == 3 && item.nomeCasella == "TERNI" || item.nomeCasella == "MESSINA" || item.nomeCasella == "FOGGIA")
                listaTerreni.Add(item as Terreno);
            else if (rosso == 3 && item.nomeCasella == "CASERTA" || item.nomeCasella == "BRINDISI" || item.nomeCasella == "ISCHIA")
                listaTerreni.Add(item as Terreno);
            else if (giallo == 3 && item.nomeCasella == "MONOPOLI" || item.nomeCasella == "ASCOLI PICENO" || item.nomeCasella == "ISOLA D'ELBA")
                listaTerreni.Add(item as Terreno);
            else if (verde == 3 && item.nomeCasella == "ANDRIA" || item.nomeCasella == "BARLETTA" || item.nomeCasella == "CATANZARO")
                listaTerreni.Add(item as Terreno);
            else if (blu == 2 && item.nomeCasella == "REGGIO CALABRIA" || item.nomeCasella == "CHIETI")
                listaTerreni.Add(item as Terreno);
        }*/
        schermata.SetActive(true);

        // Disabilito i pulsanti in eccesso
        listaPulsanti = GameObject.Find("ScrollPulsanti").GetComponentsInChildren<Button>();
        for (int i = listaPulsanti.Length - 1; i >= listaTerreni.Count; i--)
            listaPulsanti[i].gameObject.SetActive(false);

        // Do il nome giusto ai pulsanti
        Terreno[] supporto = listaTerreni.ToArray();
        for (int i = 0; i < supporto.Length; i++)
            listaPulsanti[i].GetComponentInChildren<Text>().text = supporto[i].nomeCasella;

        // Ridimensiono il box che conterrà i pulsanti
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
            // Uso questo controllo per evitare che venga costruito un edificio e distrutto il giocatore
            // I destroy non sono esattamente immediati e veniva lasciato un edificio di nessuno
            if (giocatoreDiturno.soldi - terreno.costoEdificio >= 0 && terreno.nEdifici < 5)
            {
                giocatoreDiturno.Paga(terreno.costoEdificio);
                terreno.CostruzioneEdificio();
            }
        }

        PulsanteAnnulla();
    }

    public void PulsanteAnnulla()
    {
        this.giocatoreDiturno = null;
        listaTerreni = new List<Terreno>();
        terreno = null;

        GameObject.Find("ScrollPulsanti").SetActiveRecursively(true);
        listaPulsanti = GameObject.Find("ScrollPulsanti").GetComponentsInChildren<Button>();

        for (int i = 0; i < listaPulsanti.Length; i++)
            listaPulsanti[i].GetComponentInChildren<Text>().text = "PROPRIETÀ";

        schermata.SetActive(false);
    }
}

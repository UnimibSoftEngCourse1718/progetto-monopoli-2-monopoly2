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
    private int marrone = 0, azzurro = 0, rosa = 0, arancione = 0, roso = 0, giallo = 0, verde = 0, blu = 0;
    private Button[] listaPulsanti;

    public void OnEnable()
    {
        // Trovo il giocatore attivo
        foreach (giocatore item in GameObject.FindObjectsOfType<giocatore>())
        {
            if (item.attivo)
            {
                giocatoreDiturno = item;
            }
        }

        List<CasellaAcquistabile> listaTerreni = new List<CasellaAcquistabile>();

        foreach (CasellaAcquistabile item in giocatoreDiturno.proprieta)
        {
            if(!listaTerreni.Contains(item))
                listaTerreni.Add(item);

            if (item.nomeCasella == "TERAMO" || item.nomeCasella == "SANREMO" )
            {
                // Trovato terreno marrone
            }
            if (item.nomeCasella == "L'AQUILA" || item.nomeCasella == "TRANI" || item.nomeCasella == "TORINO")
            {
                // Trovato terreno azzurro
            }
            if (item.nomeCasella == "COSENZA" || item.nomeCasella == "MILANO" || item.nomeCasella == "VIAREGGIO")
            {
                // Trovato terreno rosa
            }
            if (item.nomeCasella == "TERNI" || item.nomeCasella == "MESSINA" || item.nomeCasella == "FOGGIA")
            {
                // Trovato terreno arancione
            }
            if (item.nomeCasella == "CASERTA" || item.nomeCasella == "BRINDISI" || item.nomeCasella == "ISCHIA")
            {
                // Trovato terreno rosso
            }
            if (item.nomeCasella == "MONOPOLI" || item.nomeCasella == "ASCOLI PICENO" || item.nomeCasella == "ISOLA D'ELBA")
            {
                // Trovato terreno giallo
            }
            if (item.nomeCasella == "ANDRIA" || item.nomeCasella == "BARLETTA" || item.nomeCasella == "CATANZARO")
            {
                // Trovato terreno verde
            }
            if (item.nomeCasella == "REGGIO CALABRIA" || item.nomeCasella == "CHIETI")
            {
                // Trovato terreno blu
            }
        }

        schermata.SetActive(true);
        listaPulsanti = GameObject.Find("ScrollPulsanti").GetComponentsInChildren<Button>();

        // Disabilito i pulsanti in eccesso
        for (int i = listaPulsanti.Length - 1; i >= listaTerreni.Count; i--)
        {
            listaPulsanti[i].gameObject.SetActive(false);
        }

        CasellaAcquistabile[] supporto = listaTerreni.ToArray();
        for (int i = 0; i < supporto.Length; i++)
        {
            listaPulsanti[i].GetComponentInChildren<Text>().text = supporto[i].nomeCasella;
        }

        int altezza = listaPulsanti.Length * 55 - 5;
        GameObject.Find("ScrollPulsanti").GetComponent<RectTransform>().sizeDelta = new Vector2(0, altezza);
    }

    public void PulsanteCostruisci()
    {
        string nomeTerreno = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().GetComponentInChildren<Text>().text;

        if (terreno != null && terreno.costoEdificio <= giocatoreDiturno.soldi)
        {
            giocatoreDiturno.Paga(terreno.costoEdificio);
            terreno.CostruzioneEdificio();
        }

        PulsanteAnnulla();
        return;
    }

    public void PulsanteAnnulla()
    {
        this.giocatoreDiturno = null;

        GameObject.Find("ScrollPulsanti").SetActiveRecursively(true);
        listaPulsanti = GameObject.Find("ScrollPulsanti").GetComponentsInChildren<Button>();
        for (int i = 0; i < listaPulsanti.Length; i++)
        {
            Debug.Log(listaPulsanti[i]);
            listaPulsanti[i].GetComponentInChildren<Text>().text = "PROPRIETÀ";
        }

        schermata.SetActive(false);
        return;
    }
}

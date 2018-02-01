using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchermataPrigione : MonoBehaviour
{
    float tempo;

    private void OnEnable()
    {
        tempo = Time.timeScale;
        Time.timeScale = 0;
    }

    public void OnDisable()
    {
        Time.timeScale = tempo;
    }
}

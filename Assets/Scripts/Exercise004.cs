using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise004 : MonoBehaviour
{
    public string[] palabras;//almacena palabras
    private int Ramdom;//para rango ramdom
    private string cosaReturn;//para devolver valor del resultado

    
    void Start()
    {
        RamdomW();
    }
    private string RamdomW()
    {
        Ramdom = Random.Range(0, palabras.Length);
        Debug.Log($"{palabras[Ramdom]}");
        return cosaReturn;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise002 : MonoBehaviour
{
    public float centimetros;
    public float pul = 393701f;
    void Start()
    {
            Operator(centimetros, pul);
    }
    private void Operator(float cm, float pulgadas)
    {
        Debug.Log(message:$"Son {cm * pulgadas / 1000000} pulgadas");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise002 : MonoBehaviour
{
    public float centimetros;
    void Start()
    {
            Operator(centimetros);
    }
    private float Operator(float cm)
    {
        float result = cm * 393701 / 1000000;//crear variable con resulto cm conversion a pulgadas
        return result;
    }
}
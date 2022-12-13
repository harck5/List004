using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise001 : MonoBehaviour
{
    public int suma;//va a sumar
        void Start()
        {
        Money();
        }
        private void Money(int pasta = 5)
        {
        Debug.Log(message: $"{pasta + suma}");//pasta es lo que ya habia y suma es la variable que modifica el usuario
        }
}

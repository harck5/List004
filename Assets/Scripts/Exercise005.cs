using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise005 : MonoBehaviour
{
    public float x;//referente a cada eje
    public float y;
    public float z;

    private void Start()
    {

        OutOfBounds(x, y, z);//LLamada a la funcion

        if (OutOfBounds(x, y, z) == true)//los debugs que para los mensges que imprime 
        {
            Debug.Log("The object it's not out of bounds");
        }
        else
        {
            Debug.Log("The object it's out of bounds");
        }
    }
    private bool OutOfBounds(float limitX, float limitY, float limitZ)//comprobacion de los numeros absolutos que vayamo a escribir en las variables
    {
        if (transform.position.x <= limitX && transform.position.y <= limitY && transform.position.z <= limitZ && transform.position.x >= (-1 * limitX) && transform.position.y >= (-1 * limitY) && transform.position.z >= (-1 * limitZ))
        {
            return true;//si esta entre 1 y -1 true
        }
        else
        {
            return false;//si esta fuera false
        }
    }
}

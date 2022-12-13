using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise003 : MonoBehaviour
{
    public int x;
    public int y;
    void Start()
    {
        RandomNum(x, y);
    }
    private Vector3 RandomNum(int numX, int numY)
    {
        return transform.position = new Vector3(Random.Range(numX, numY), 0, 0);//retorna un vector con una x ramdom
    }
}

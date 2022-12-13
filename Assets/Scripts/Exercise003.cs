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
    private void RandomNum(int numX, int numY)
    {
        transform.position = new Vector3(Random.Range(numX, numY), 0, 0);
        Debug.Log(message: $"{transform.position.x} random num");
    }
}

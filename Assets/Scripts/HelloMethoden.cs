using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        //at 2) Instanzvariable nutzen
        Debug.Log("before startValue: " + startValue);
        Increment();

        //at 3)
        Debug.Log("before startValue3: " + startValue3);
        IncrementByX(Random.Range(1, 10));
        Debug.Log("after start Value");

        //at 4)
        Debug.Log("before startValue");

        
    }

    private void DecrementByOne(int val)
    {
        private void OnValidate()
    {
        --;
        Debug.Log("val: " + OnValidate);
    }
}


    private void IncrementByX(int valToAdd)
    {
        StartValue3 += valToAdd;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

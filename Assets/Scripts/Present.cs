using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Present : MonoBehaviour
{
    public int value;
    private PresentCounter presentCounter;

    // Start is called before the first frame update
    void Start()
    {
        presentCounter = FindObjectOfType<PresentCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            presentCounter.IncreasePresents(value);
            Destroy(gameObject);
        }
    }
}

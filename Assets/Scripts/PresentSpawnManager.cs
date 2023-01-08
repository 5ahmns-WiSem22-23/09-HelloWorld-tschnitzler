/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentSpawnManager : MonoBehaviour
{
    public GameObject present;
    //public GameObject present2;

    //predefined space boundaries
    float xMin = 0.0f;
    float xMax = 10.0f;
    float yMin = 0.0f;
    float yMax = 10.0f;

    // Generate a random position for the sprite
    float xPos = Random.Range(xMin, xMax);
    float yPos = Random.Range(yMin, yMax);

    // Set the position of the sprite
    Vector2 spritePosition = new Vector2(xPos, yPos);

    // Instantiate the sprite at the random position
    GameObject sprite = Instantiate(spritePrefab, spritePosition, Quaternion.identity);


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiateSprites());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
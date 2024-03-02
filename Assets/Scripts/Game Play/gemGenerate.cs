using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemGenerate : MonoBehaviour
{
    public Sprite[] gemSprites = new Sprite[3]; // array to hold the gem sprites
    public int[] gemOrder = {0, 1, 2, 3} ;// list to hold the random gem order

    void Start()
    {
        // shuffle the array to create a random order
        for (int i = gemOrder.Length - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            int temp = gemOrder[i];
            gemOrder[i] = gemOrder[j];
            gemOrder[j] = temp;
        }

        Debug.Log(string.Join(",", gemOrder));
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

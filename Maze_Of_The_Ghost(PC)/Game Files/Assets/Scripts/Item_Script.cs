using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Script : MonoBehaviour
{
    public GameObject key; // Reference to the key object
    public GameObject snowball1, snowball2, snowball3; // References to snowball objects
    public GameObject battery1, battery2, battery3; // References to battery objects

    void Start()
    {
        // Initialization is not required as the items are manipulated in the Update method
    }

    void Update()
    {
        // Apply rotation effects to the items to make them visually dynamic
        key.transform.Rotate(0, 0, -0.8f);
        snowball1.transform.Rotate(0, -0.5f, 0);
        snowball2.transform.Rotate(0, -0.5f, 0);
        snowball3.transform.Rotate(0, -0.5f, 0);
        battery1.transform.Rotate(0, -0.5f, 0);
        battery2.transform.Rotate(0, -0.5f, 0);
        battery3.transform.Rotate(0, -0.5f, 0);
    }
}

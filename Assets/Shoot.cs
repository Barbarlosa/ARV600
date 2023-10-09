using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int Coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("started!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.name == "ZombieRig")
        {
            Coins++;
            Debug.Log("Resource Collected! Current Coins:" + Coins);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFloor : MonoBehaviour
{

    public Vector3 editPosition = new Vector3(0f, 2f, 0f);


    // Start is called before the first frame update
    void Start()
    {
        transform.position = editPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

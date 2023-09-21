using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestRotatingCube : MonoBehaviour


{

    public Vector3 editRotation = new Vector3 (0f,2f,0f);
    public Keyboard keyboard;

    // Start is called before the first frame update
    void Start()
    {
        keyboard = Keyboard.current;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard.wKey.isPressed)
        {
            transform.Rotate(new Vector3(0f, 2f, 0f));
        }
        if (keyboard.sKey.isPressed)
        {
            transform.Rotate(new Vector3 (0f,6f,0f));
        }
    }
}

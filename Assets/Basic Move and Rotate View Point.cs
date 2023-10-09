using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasicMoveandRotateViewPoint : MonoBehaviour
{

    public Vector3 moveFront = new Vector3(0f, 0f,z:1f);
    public Vector3 moveBack = new Vector3(0f, 0f, z:-1f);
    public Vector3 rotateLeft = new Vector3(0f, y: -1f, 0f);
    public Vector3 rotateRight = new Vector3(0f, y: 1f, 0f);

    public Keyboard keyboard;
    public Mouse mouse;
    public GameObject fattyCannonPrefab;
    public Boolean build = true;
    
    // Start is called before the first frame update
    void Start()
    {
        keyboard = Keyboard.current;

    }

    // Update is called once per frame
    void Update()
    {

        if (keyboard.bKey.isPressed)
        {
            if (build)
            {
                Vector3 position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(fattyCannonPrefab, position, Quaternion.identity);
                build = false;
            }
        }
        else
        {
            build = true;
        }



        if (keyboard.wKey.isPressed)
        {
            transform.Translate(new Vector3(moveFront.x,Terrain.activeTerrain.SampleHeight(transform.position) - gameObject.transform.position.y,moveFront.z));
        }

        if (keyboard.sKey.isPressed)
        {
            transform.Translate(new Vector3(moveBack.x, Terrain.activeTerrain.SampleHeight(transform.position) - gameObject.transform.position.y, moveBack.z));
        }
        
        if (keyboard.dKey.isPressed)
        {
            transform.Rotate(rotateRight);
        }
        
        if (keyboard.aKey.isPressed)
        {
            transform.Rotate(rotateLeft);
        }

    }
}


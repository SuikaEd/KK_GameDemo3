﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-400, 300, 0));
        }

        
    }
}

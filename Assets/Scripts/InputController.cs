﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public float Vertical;
    public float Horizontal;
    public Vector2 MouseInput;
    public bool fire1;
    public bool reload;
    public bool primaryAttack;


    void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        MouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        fire1 = Input.GetButton(gameConstants.fire1);
        primaryAttack = Input.GetMouseButtonDown(gameConstants.primaryAttack);

        reload = Input.GetKey(KeyCode.R);
    }
}

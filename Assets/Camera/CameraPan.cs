﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour {

    private GameObject player;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	

	void LateUpdate ()
    {
        print("RHoriz " + Input.GetAxis("RHoriz"));
        // print("RVertical " + Input.GetAxis("RVertical"));
        transform.LookAt(player.transform);

    }
}

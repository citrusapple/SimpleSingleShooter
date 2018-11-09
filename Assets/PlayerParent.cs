﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParent : MonoBehaviour {
    public Vector3 CastlePosition;
    private Vector3 targetPosition;
    public bool enteredCastle;
    // Use this for initialization
    void Start () {
        targetPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);

    }
    public void MoveToCastle()
    {
        Debug.Log("Moved into castle");
        enteredCastle = true;
        targetPosition = CastlePosition;
    }
}

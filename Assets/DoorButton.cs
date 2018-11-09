using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour {
    public Door door;
    public PlayerParent playerParent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnLook()
    {
        Debug.Log("button lowering door");
        door.lowerDoor();
        Debug.Log("button moves player");
        playerParent.MoveToCastle();
    }
}

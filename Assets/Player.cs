using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.GetComponent<DoorButton>() != null)
            {
                Debug.Log("looked at button");
                hit.transform.GetComponent<DoorButton>().OnLook();
            }
        }
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("I'm hitting enemies!");
            RaycastHit enemyHit;
            if (Physics.Raycast(transform.position, transform.forward, out enemyHit))
            {
                Debug.Log("I aimed correctly at the enemy");
                if (enemyHit.transform.GetComponent<Enemy>() != null)
                {
                    Debug.Log("this destroys the enemy");
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}

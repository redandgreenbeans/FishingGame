using UnityEngine;
using System.Collections;

public class Penguin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        Rigidbody2D penguin = gameObject.GetComponent<Rigidbody2D>();

        // Move right
        if (Input.GetKey("d"))
        {
            penguin.AddForce(20*Vector2.right);            
        }

        // Move left
        if (Input.GetKey("a"))
        {
            penguin.AddForce(-20*Vector2.right);
        }

        // Move up
        if (Input.GetKey("w"))
        {
            penguin.AddForce(20 * Vector2.up);
        }

        // Move Down
        if (Input.GetKey("s"))
        {
            penguin.AddForce(-20 * Vector2.up);
        }

        if (!Input.GetKey("s") && !Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            penguin.rigidbody2D.velocity = Vector2.zero;
        }

    }
}

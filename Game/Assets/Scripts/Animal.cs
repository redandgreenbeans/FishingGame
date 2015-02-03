using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

    bool isFlipped;

	// Use this for initialization
	void Start () {
        isFlipped = false;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 scale = transform.localScale;
        if (rigidbody2D.velocity.x > 0 && !isFlipped)
        {
            scale.x *= -1;
            isFlipped = true;
        }
        else if (rigidbody2D.velocity.x < 0 && isFlipped)
        {
            scale.x *= -1;
            isFlipped = false;
        }

        transform.localScale = scale;
	}
}

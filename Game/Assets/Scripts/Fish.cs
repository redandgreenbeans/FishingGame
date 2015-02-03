using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    void FixedUpdate()
    {
        GameObject penguin = GameObject.Find("penguin");
        Vector3 fishPosition = transform.position;
        Vector2 penguinPosition = penguin.rigidbody2D.position;
        float distanceBetweenFishAndPenguin = Mathf.Sqrt(Mathf.Pow((penguinPosition.x - fishPosition.x), 2) + Mathf.Pow((penguinPosition.y - fishPosition.y), 2));

        if (distanceBetweenFishAndPenguin < 10)
        {
            // if penguin is too close and moving towards fish, move away from penguin
            Vector2 penguinVelocity = penguin.rigidbody2D.velocity;
            if (isPenguinMovingTowardsFish(fishPosition, penguinPosition, penguinVelocity)) 
            {
                rigidbody2D.AddForce(20*penguinVelocity);
            }
        }
    }

    private bool isPenguinMovingTowardsFish(Vector3 fishPosition, Vector2 penguinPosition, Vector2 penguinVelocity)
    {
        // the diplacement of the fish with respect to the penguin
        float displacementX = fishPosition.x - penguinPosition.x;
        float displacementY = fishPosition.y - penguinPosition.y;

        // if the penguin is moving towards the fish in the x direction, return true
        if (displacementX < 0 && penguinVelocity.x < 0 || displacementX > 0 && penguinVelocity.x > 0) 
        {
            return true;
        }

        // if the penguin is moving towards the fish in the y direction, return true
        if (displacementY < 0 && penguinVelocity.y < 0 || displacementY > 0 && penguinVelocity.y > 0)
        {
            return true;
        }

        // Otherwise the penguin in not going towards the fish
        return false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "penguin")
        {
            // update score
            FishScore.updateScore();
            Destroy(this.gameObject);
        }
    }
}

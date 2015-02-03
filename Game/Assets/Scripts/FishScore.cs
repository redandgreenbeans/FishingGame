using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FishScore : MonoBehaviour {

    static int currentScore;
    int numberOfFish;
    Text scoreText;

	// Use this for initialization
	void Start () {
        currentScore = 0;
        scoreText = GetComponent<Text>();
        Fish[] fish = FindObjectsOfType<Fish>();
        numberOfFish = fish.Length;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Fish eaten: " + currentScore;
        if (currentScore == numberOfFish)
        {
            // Game win
            scoreText.text = "You win!";
        }
	}

    public static void updateScore()
    {
        currentScore++;
    }
}

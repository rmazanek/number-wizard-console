using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardC : MonoBehaviour
{

    int guessMin = 1;
    int guessMax = 1000;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guessMin = 1;
        guessMax = 1000;
        guess = 500;

        Debug.Log("Welcome to the number wizzerd.");
        Debug.Log("Think of a number between: " + guessMin + " and " + guessMax);
        Debug.Log("Tell me if your number is higher or lower than " + guess + ".");
        Debug.Log("Push up = higher, Push down = lower, Push enter = correct");
        guessMax = guessMax + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            guessMin = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            guessMax = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("We got it!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (guessMax  + guessMin)/2;
        Debug.Log("Is it higher or lower than... " + guess);
    }
}

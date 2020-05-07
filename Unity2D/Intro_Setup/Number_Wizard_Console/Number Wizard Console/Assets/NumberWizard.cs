using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNumber;
    int minNumber;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxNumber = 1000;
        minNumber = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please Pick a Number!");
        Debug.Log("With the Highest Number Being: " + maxNumber);
        Debug.Log("With the Lowest Number Being: " + minNumber);
        Debug.Log("Is your number higher or lower than: " + guess);
        Debug.Log("Push Up if your number is higher, Push Down if your number is lower, Push Enter if we have the correct number");
        maxNumber = maxNumber + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))  
        {
            minNumber = guess;
            NextGuess();
            
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))  
        {
            maxNumber = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("Hooray! We've Got the Correct Number.");
            StartGame();
        }
            
        
              
        
    }

    void NextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is your number higher or lower than: " + guess);
    }
}

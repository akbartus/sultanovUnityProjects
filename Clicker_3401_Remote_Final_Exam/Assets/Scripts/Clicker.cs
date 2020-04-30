using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clicker : MonoBehaviour
{

  
    public Text scoreText; //Create public field to insert text there
    int currentScore = 0; // Set score, to be displayed in text, as 0
    public Text displayText; // Create public field to insert another text there
    public GameObject hiddenCube; // Create public field to insert image
    


 
    void OnMouseDown()
    {  
        currentScore += 1; // On mouse click, add +1 to currentScore
        scoreText.text = "Current Score: " + currentScore.ToString(); // Show "Current Score: " and updated score on each click

    }

    void Update()
    {
        if (currentScore == 10)
        { 
           displayText.text = "Good job, Keep Clicking!";
        }
        else if (currentScore == 20)
        { 
            displayText.text = "You reached 20 clicks! Wow!";
        }
        else if (currentScore == 30)
        { 
            displayText.text = "You reached 30 clicks! You are a pro!";
        }
        else if (currentScore == 40)
        {
            displayText.text = "You reached 30 clicks! You are a pro!";
        }
        else if (currentScore == 50)
        {
            displayText.text = "Try to click more to see magic!";
        }
        else if (currentScore == 60)
        {
            displayText.text = "";
            hiddenCube.SetActive(true);
        }
        else if (currentScore == 70)
        {
            SceneManager.LoadScene(0);
        }


        // 
    }
}
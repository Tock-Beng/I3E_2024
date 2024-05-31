using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    /// <summary>
    /// The UI text that stores the player score
    /// </summary>
    public TextMeshProUGUI scoreText;

    private int currentScore = 0;
    private void Awake()
    {
        //if there is no game manager, player will be the game manager
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  
        }

        //if there is game manager and it is not "myself" (the player?)
        else if (instance != null && instance != this)
        {
            //destroy "myself" to ensure that there is only one game manager
            Destroy(gameObject);
        }
    }

    public void IncreaseScore(int scoreToAdd)
    {
        //Increase the score of the player by scoreToAdd
        currentScore += scoreToAdd;
        scoreText.text = currentScore.ToString();
    }
}

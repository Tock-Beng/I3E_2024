/*
 * Author: Tan Tock Beng
 * Date: 06/05/2024
 * Description: 
 * function for player such as displaying remaining collectibles, interacting with doors, and score
 */
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Player : MonoBehaviour
{
    /// <summary>
    /// display texts and HUDs
    /// </summary>
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI collectiblesText;

    public GameObject collectibleMessage;
    public GameObject gameRules;

    /// <summary>
    /// The current score of the player
    /// </summary>
    int currentScore = 0;

    /// <summary>
    /// Store the current door in front of the player
    /// </summary>
    Door currentDoor;

    //the total number of collectibles
    int totalCollectibles = 25;

    //start of the code
    private void Start()
    {
        //display the points & number of remaining collectibles at the start of the game
        scoreText.text = "Points: " + currentScore.ToString();
        collectiblesText.text = "Remaining Collectibles: " + totalCollectibles.ToString();

        StartCoroutine(DisplayGameRules());
    }

    private void Update()
    {
        //testing
        if (totalCollectibles == 0)
        {
            // after a certain condition
            // SetActive(true) makes the object appear.
            collectibleMessage.SetActive(true);

        }
    }

    /// <summary>
    /// Increases the score of the player by <paramref name="scoreToAdd"/>
    /// </summary>
    /// <param name="scoreToAdd">The amount to increase by</param>
    public void IncreaseScore(int scoreToAdd)
    {
        // Increase the score of the player by scoreToAdd
        currentScore += scoreToAdd;
        //display the number points in the UI
        scoreText.text = "Points: " + currentScore.ToString();

        //deduct the number of collectibles by 1
        totalCollectibles--;
        // Update the collectibles text in the UI
        collectiblesText.text = "Remaining Collectibles: " + totalCollectibles.ToString();
    }

    /// <summary>
    /// descreases the score of the player
    /// </summary>
    /// <param name="scoreToDeduct"></param>
    public void DeductScore(int scoreToDeduct)
    {
        // deduct the score of the player by deductScore
        currentScore -= scoreToDeduct;
        //display the number points in the UI
        scoreText.text = "Points: " + currentScore.ToString();
    }


    public void UpdateDoor(Door newDoor)
    {
        currentDoor = newDoor;
    }

    /// <summary>
    /// when the player press "E" near the door, the following lines of code will be executed
    /// </summary>
    void OnInteract()
    {
        // This is "null check", checks if there is a door in front
        if (currentDoor != null)
        {
            currentDoor.OpenDoor();
            currentDoor = null;
        }
    }

    /// <summary>
    /// deducts from the remaining collectible 
    /// </summary>
    /// <param name="collectiblesToDeduct"></param>
    public void DeductCollectibles(int collectiblesToDeduct)
    {
        totalCollectibles -= collectiblesToDeduct;
        collectiblesText.text = "Remaining Collectibles: " + totalCollectibles.ToString();

    }

    /// <summary>
    /// display the game rules for 7 seconds before hiding
    /// </summary>
    /// <returns></returns>
    IEnumerator DisplayGameRules()
    {
        // Show the game rules
        gameRules.SetActive(true);

        // Wait for 7 seconds
        yield return new WaitForSeconds(7);

        // Hide the game rules
        gameRules.SetActive(false);
    }
}

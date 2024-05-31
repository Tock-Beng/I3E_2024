using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int targetSceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        //check whether the object has the "Player" tag
        if (other.tag == "Player")
        {
            //if it is the player, change scenes
            ChangeScene();
        }
    }
    
    void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneIndex);
    }
}

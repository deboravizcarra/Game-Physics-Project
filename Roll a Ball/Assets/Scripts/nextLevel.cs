using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public int nextScene;

    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene(4);
                PlayerPrefs.DeleteAll();
            }
            else
            {
                SceneManager.LoadScene(nextScene);

                if (nextScene > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextScene);
                }
            } 
        }
    }
}

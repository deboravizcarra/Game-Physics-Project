using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public Button[] lvlButtons;

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);
        for(int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }

    public void LoadLevel(int n)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + n);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}

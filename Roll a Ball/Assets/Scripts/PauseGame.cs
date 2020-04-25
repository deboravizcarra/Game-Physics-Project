using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject menuUI;

    public void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }
}

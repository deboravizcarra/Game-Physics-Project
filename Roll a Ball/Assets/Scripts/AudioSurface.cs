using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Button btnOn;
    public Button btnOff;

    public AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        btnOn = GetComponent<Button>();
        btnOff = GetComponent<Button>();

        // Either use this, or assign the component from inspector
        audioSource = GetComponent<AudioSource>();

        btnOn.onClick.AddListener(() => PlayAudio());
        btnOff.onClick.AddListener(() => StopAudio());
    }

    void PlayAudio()
    {
        audioSource.volume = 0.5f;
    }

    void StopAudio()
    {
        audioSource.volume = 0f;
    }
}

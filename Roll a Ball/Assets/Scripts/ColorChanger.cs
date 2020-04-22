using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material[] colors;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = colors[5];
    }

    public void newColor(int n)
    {
        for(int i = 0; i < colors.Length; i++)
        {
            if (i == n)
                rend.sharedMaterial = colors[i];
        }
    }
}

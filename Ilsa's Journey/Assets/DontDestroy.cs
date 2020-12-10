using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Object.DontDestroyOnLoad example.
//
// This script example manages the playing audio. The GameObject with the
// "music" tag is the BackgroundMusic GameObject. The AudioSource has the
// audio attached to the AudioClip.

public class DontDestroy : MonoBehaviour
{   
    public bool[] mapStatus = new bool[2] { false, false };
    public int current = 1; 

    void Awake()
    {   
        
        mapStatus = new bool[2] { false, false };
        current = 1; 

        DontDestroyOnLoad(this.gameObject);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 playFloor = player.transform.position + Vector3.down;

        if (playFloor == transform.position){
            //End Game
			SceneManager.LoadScene("StartScreen");
        }    
    }
}

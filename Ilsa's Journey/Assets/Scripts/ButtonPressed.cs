using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {   
        anim = GameObject.Find("RotatingGO").GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject player = GameObject.Find("Player");
        Vector3 playFloor = player.transform.position + Vector3.down;

        if (playFloor == transform.position){
            anim.enabled = true;
        }     

    }

}


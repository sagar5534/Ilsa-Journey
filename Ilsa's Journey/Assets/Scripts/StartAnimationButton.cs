using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimationButton : MonoBehaviour
{

    Animator anim;
	public GameObject animObject; 
	public GameObject GlowObject;

    // Start is called before the first frame update
    void Start()
    {   
        anim = animObject.GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject player = GameObject.Find("Player");
        Vector3 playFloor = player.transform.position + Vector3.down;

        if (playFloor == transform.position){
            anim.enabled = true;
			
			Color color = Color.green;
			float f = 0.4f; 
			GlowObject.GetComponent<Renderer>().material.SetColor("_EmissionColor",color*f);
			 
        }     

    }

}


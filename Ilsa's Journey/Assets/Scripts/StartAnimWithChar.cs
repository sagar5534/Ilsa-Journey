using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimWithChar : MonoBehaviour
{
	
    Animator anim;
	Animator playerAnim;
	public GameObject animObject; 
	public GameObject GlowObject;
	public GameObject player;
	public GameObject[] objects;
	public Light lt;
	
    // Start is called before the first frame update
    void Start()
    {	
		foreach (GameObject element in objects)
		{
			print(element);
			Animator anim = element.GetComponent<Animator>();
	        anim.enabled = false;
		}
			
        // anim = animObject.GetComponent<Animator>();
 // 		playerAnim = player.GetComponent<Animator>();
 //
 //        anim.enabled = false;
 // 		playerAnim.enabled = false;
				
    }

    // Update is called once per frame
    void Update()
    {
        GameObject playerobject = GameObject.Find("Player");
        Vector3 playFloor = playerobject.transform.position + Vector3.down;

        if (playFloor == transform.position){
			
			print("Player on button running animations");
			
			foreach (GameObject element in objects)
			{
				print(element);
				Animator anim = element.GetComponent<Animator>();
		        anim.enabled = true;
			}
			
			Color color = Color.green;
			float f = 0.4f; 
			GlowObject.GetComponent<Renderer>().material.SetColor("_EmissionColor",color*f);
			lt.color = Color.green;
        }   
		
    }
}

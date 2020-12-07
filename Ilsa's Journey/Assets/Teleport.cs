using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public Vector3 location;
	public GameObject button;
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
					
        	Vector3 playFloor = button.transform.position + Vector3.up;
			print(transform.position);
        	if (playFloor == transform.position){
				print("Made it");
				transform.position = location;
				print(transform.position);
				
				
				MoveCharacter script = GetComponent("MoveCharacter") as MoveCharacter;
				GetComponent<MoveCharacter>().Init();
				
				
				//script.StandingFloor = button;
				
				enabled = false;
        	}     
		
    }
}

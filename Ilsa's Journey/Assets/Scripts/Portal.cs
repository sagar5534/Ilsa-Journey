using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
	public Vector3 endLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		GameObject player = GameObject.Find ("Player");
        Vector3 playFloor = player.transform.position + Vector3.down;

        if (playFloor == transform.position){
            //Make Portal Move
			player.transform.position = endLocation;
			player.GetComponent<MoveCharacter>().Init();
        }    
    }
}

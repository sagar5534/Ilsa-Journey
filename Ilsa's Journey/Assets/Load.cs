using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nextMove () {
        
        int currentMap = StaticClass.scene;
         if (currentMap == 1) {
    	    SceneManager.LoadScene("Map 1");
        }else{
    	    SceneManager.LoadScene("Map 2");
        }

    }

}

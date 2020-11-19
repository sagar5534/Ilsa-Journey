using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayRound () {
    	SceneManager.LoadScene("Map 1");
    }
	
	public void QuitGame () {
		Application.Quit();
	}
    
}

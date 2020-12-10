using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameStarted : MonoBehaviour
{   

    public int currentMap = 1; 

    Sprite map1Logo; 
    Sprite map2Logo; 

    // Start is called before the first frame update
    void Start()
    {   
        
        map1Logo = Resources.Load<Sprite>("map1");
        map2Logo = Resources.Load<Sprite>("map2");

    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject levelName = GameObject.Find("LevelName");
        GameObject levelStatus = GameObject.Find("LevelStatus");
        GameObject mapImage = GameObject.Find("MapImage");

        DontDestroy test = gameObject.GetComponent<DontDestroy>();

        if (currentMap == 1){

            levelName.GetComponent<TMPro.TextMeshProUGUI>().text = "1. Dusk Castle";
            mapImage.GetComponent<Image>().sprite = map1Logo;


        }else if (currentMap == 2){

            levelName.GetComponent<TMPro.TextMeshProUGUI>().text = "2. Skyward Castle";
            mapImage.GetComponent<Image>().sprite = map2Logo;

        }

        if (test.mapStatus[currentMap - 1]){
            levelStatus.GetComponent<TMPro.TextMeshProUGUI>().text = "Chapter Cleared";
        }else{
            levelStatus.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        }

    }

    public void NextMap () {
        if (currentMap == 1) {
            currentMap = 2;
        }
    }

    public void PrevMap () {
        if (currentMap == 2) {
            currentMap = 1;
        }
    }

    public void PlayRound () {
        
        StaticClass.scene = currentMap;
    	SceneManager.LoadScene("LoadScreen");

    }
	
	public void QuitGame () {
		Application.Quit();
	}
    

}

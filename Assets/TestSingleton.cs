using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSingleton : MonoBehaviour
{

    public static TestSingleton instance = null;
    public  int playerScore;
    //use awake for singleton
    void Awake()
    {
        //check to see if null
        //if so, there is nothing there, this has never been run there so signs  of any other sngleton in existance. 
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            //this is not the first component that has run
            Destroy(this.gameObject);
        }
        // we want to keep this since we are the component that is going to be going betwwen scenes
        DontDestroyOnLoad(this.gameObject);

        //load data saved and out in places needed.
    



    }
        void OnLevelWasLoaded()
    { 
        Scene currentScene = SceneManager.GetActiveScene();
    
        //get reference to current scene
        string sceneName = currentScene.name;

        if (sceneName == "scene2")
        {
            //Display highschores
            Debug.Log(playerScore);
            SortHighscore();
        }
    }
    void SortHighscore()
    {

    }
}

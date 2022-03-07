/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited:
 * Last Edited by:
 * 
 * Descritpion: Game Manager Object
 * */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region GameManager Singleton
    static private GameManager gm;      //reference to game manager
    static public GameManager GM { get { return gm;  } }   //public game manager access

    
    void CheckForManager()
    {
        if (gm == null)
        {
            gm = this;
        }
        else Destroy(this.gameObject);
        DontDestroyOnLoad(this);
    }

    #endregion

    static public Color[] speedColors = { new Color(1, 1, 1, 1), new Color(1, 0.8933854f, 0, 1), new Color(0, 0.6969085f, 1, 1), new Color(1, 0.1336182f, 0, 1), new Color(0.135129f, 0, 1, 1), new Color(1, 0, 0.8698916f, 1) };//colors for speed always in an available place

    [Header("Scene Settings")]
    public string startScene;
    public string completionScene;     //there is no way to die, so there is only a game completion scene;
    public string[] levels;
    public static int currentScene = 0;
    private int levelCount;

    public void StartGame()      //public method to start the game
    {
        levelCount = 0;
        SceneManager.LoadScene(levels[levelCount]);
    }

    public void ExitGame()    //public method to force exit the game
    {
        Application.Quit();
        Debug.Log("Game Theoretically Exited");
    }

    public void FinishGame()
    {
        SceneManager.LoadScene(completionScene);
    }

    public void NextLevel()
    {
        levelCount++;
        if (levelCount < levels.Length)
        {
            SceneManager.LoadScene(levels[levelCount]);
        }
    }
}

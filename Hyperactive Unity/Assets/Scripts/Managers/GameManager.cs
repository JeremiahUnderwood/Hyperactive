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

    static private GameManager gm;      //reference to game manager
    static public GameManager GM { get { return gm;  } }   //public game manager access
    public Color[] colorList;
    static public Color[] speedColors = {new Color(1, 1, 1, 1), new Color(1, 0.8933854f, 0, 1), new Color(0, 0.6969085f, 1, 1), new Color(1, 0.1336182f, 0, 1), new Color(0.135129f, 0, 1, 1), new Color(1, 0, 0.8698916f, 1) };//colors for speed always in an available place
    
    void CheckForManager()
    {
        if (gm == null)
        {
            gm = this;
        }
        else Destroy(this.gameObject);
        DontDestroyOnLoad(this);
    }
}

/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited:
 * Last Edited by:
 * 
 * Descritpion: References Game Manager for final scene
 * 
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerReference : MonoBehaviour
{

    private GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void getStart()
    {
        manager.StartGame();
    }
    public void getExit()
    {
        manager.ExitGame();
    }
}

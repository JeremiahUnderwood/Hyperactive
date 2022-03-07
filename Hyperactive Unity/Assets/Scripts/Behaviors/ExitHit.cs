/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited:
 * Last Edited by:
 * 
 * Descritpion: Changes Level When Hit
 * 
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHit : MonoBehaviour
{
    [SerializeField] private bool finalLevel = false;
    private bool jimmyIn;
    private GameManager manager;
    void Start()
    {
        jimmyIn = false;
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Jimmy")
        {
            jimmyIn = true;
            Destroy(other.gameObject);
        }
        if ((other.gameObject.tag == "Jacky") && jimmyIn)
        {
            if (finalLevel) manager.FinishGame();
            else manager.NextLevel();
        }
    }
}

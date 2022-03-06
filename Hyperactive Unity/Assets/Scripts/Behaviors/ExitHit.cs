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
    private bool jimmyIn;
    void Start()
    {
        jimmyIn = false;
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
            Debug.Log("Level Beat");
        }
    }
}

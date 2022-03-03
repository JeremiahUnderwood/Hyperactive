/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited:
 * Last Edited by:
 * 
 * Descritpion: controls broken piece behavior
 * 
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{

    [SerializeField] private float lifeSpan;  //lifespan in seconds
    [SerializeField] private Rigidbody rb;     //reference to rigidyBody

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimedDestroy());                   //start self destruct sequence
    }

    IEnumerator TimedDestroy()
    {
        yield return new WaitForSeconds(lifeSpan);        //destroy after set time
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 490 * Time.deltaTime);             //artificial gravity
    }
}

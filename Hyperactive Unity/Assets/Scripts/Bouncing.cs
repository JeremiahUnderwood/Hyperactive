/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited:
 * Last Edited by:
 * 
 * Descritpion: Makes Attached Object Move and Bounce consistantly
 * 
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;    //reference to rigidbody component
    public float speed;      //easily editable speed accessable by other objects

    void Start()
    {
        rb.velocity = new Vector3(speed, 0, 0);  //set initial speed
    }

    void Update()
    {
        //maintain speed
        Vector3 unscaledVel = rb.velocity;
        float hypotenuse = Mathf.Sqrt((unscaledVel.x * unscaledVel.x) + (unscaledVel.y * unscaledVel.y));  //getting hypotenuse of the vector for math reasons
        if (hypotenuse != 0) {                                             //hypotenuse being 0 will cause a divide by zero error
            float newX = (unscaledVel.x / hypotenuse) * speed;
            float newY = (unscaledVel.y / hypotenuse) * speed;             //doing it this way rather than arcsin/arccos/arctan keeps the sign without any caviots
            rb.velocity = new Vector3(newX, newY, 0);
        }
    }
}

/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited: 3/1/2022
 * Last Edited by:
 * 
 * Descritpion: Makes Attached Object move with WASD
 * 
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;        //reference to objects own rigidbody component
    [SerializeField] private float moveSpeed;     //easily editable speed


    // Update is called once per frame
    void Update()
    {
        float xScale = 0f;      //get change in x and y
        float yScale = 0f;
        if (Input.GetKey(KeyCode.A))
            xScale -= 1;
        if (Input.GetKey(KeyCode.D))
            xScale += 1;
        if (Input.GetKey(KeyCode.W))
            yScale += 1;
        if (Input.GetKey(KeyCode.S))
            yScale -= 1;
        rb.velocity = (moveSpeed * (new Vector3(xScale, yScale, 0)));  //Apply
    }
}

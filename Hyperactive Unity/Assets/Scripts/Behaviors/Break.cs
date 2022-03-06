/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited: 3/6/2022
 * Last Edited by:
 * 
 * Descritpion: controls breakable object behavior
 * 
 * */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Break : MonoBehaviour
{

    public float threshHold = 10;     //How fast Jimmy has to be going to break this
    public GameObject piece;     //reference to the piece object to spawn
    [SerializeField] private float forceScale = 1; //determines how violent the wall breaking is (defaults to 1 so there is some force).
    private int size;
    [SerializeField] private Canvas canvas;
    [SerializeField] private Text text;
    [SerializeField] private Light halo;

    // Start is called before the first frame update
    void Start()
    {
        size = (int)this.transform.localScale.x;   //record size
        canvas.transform.localScale = new Vector3(canvas.transform.localScale.x / size, 1, 1);      //keep number at constant size

        int speedIndex = (int)((threshHold - 10) / 2);         //set color based on threshhold for convinience sake
        halo.color = GameManager.speedColors[speedIndex];
        text.text = speedIndex.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jimmy")                           //check if object is even the ball
        {
            Bouncing jim = collision.gameObject.GetComponent<Bouncing>();
            if (jim.speed >= threshHold)                                      //check if ball is going fast enough to break
            {
                this.transform.localScale = new Vector3(1, 1, 1);
                for (int i = 0; i < size; i++) {                                                                      //spawn pieces
                    GameObject instance = Instantiate(piece, this.transform.position, this.transform.rotation);
                    float evencheck = ((size + 1) % 2) * .5f;          //adjusts since even numbers ended up a bit off when breaking
                    instance.transform.position = this.transform.TransformPoint(new Vector3((i - (size/2) + evencheck), 0, 0));
                    instance.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(5 * (i - size/2)/size, 2 * 1/(Math.Abs(size/2 - i) + 1), 0) * forceScale);        //complicated formulat for calculating force to add
                }
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

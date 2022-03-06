/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited:
 * Last Edited by:
 * 
 * Descritpion: Speeds up or slows down Jimmy
 * 
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChange : MonoBehaviour
{

    public float speedchange;                    //change in speed
    private float limit;                         //max speed

    // Start is called before the first frame update
    void Start()
    {
        if (speedchange > 0) limit = 20;
        else limit = 10;
    }

    // Update is called once per frame
    void update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Jimmy") {
            if (((limit == 20) && (other.gameObject.GetComponent<Bouncing>().speed < 20)) || ((limit == 10) && (other.gameObject.GetComponent<Bouncing>().speed > 10))) //putting this all in one piece is confusing, but means there will be slightly fewer calculations when processing, and I'm to OCD to do the less efficeint method
            {
                other.gameObject.GetComponent<Bouncing>().speed += speedchange;
                other.gameObject.GetComponent<Bouncing>().ChangeColor();
            }
        }
    }
}

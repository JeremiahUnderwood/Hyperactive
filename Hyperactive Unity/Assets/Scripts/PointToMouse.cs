/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited:
 * Last Edited by:
 * 
 * Descritpion: Makes Attached Object Point to Mouse Position
 * 
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToMouse : MonoBehaviour
{
    [SerializeField] private Camera roomCam;        //room camera
    [SerializeField] private float distFromSurface; //distance camera is from the surface of the floor.

    void Update()
    {
        //I coulda just used LookAt(Input.MousePosition) but instead I spent way to long doing this with actual trig. Me so smart!

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distFromSurface);    //find where mouse is pointing.
        mousePos = roomCam.ScreenToWorldPoint(mousePos);

        float deltaX = this.transform.position.x - mousePos.x;          //find angle to rotate
        float deltaY = this.transform.position.y - mousePos.y;
        float degree = Mathf.Atan(deltaY / deltaX) * (180 / Mathf.PI);
        if (deltaX > 0) degree += 180;
        this.transform.rotation = Quaternion.Euler(0, 0, degree);
    }
}

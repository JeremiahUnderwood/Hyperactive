/**
 * 
 * Created By Jeremiah Underwood
 * 
 * Last Edited: 3/2/2022
 * Last Edited by:
 * 
 * Descritpion: Makes Camera Follow Target object at distance z
 * 
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float zPos;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.position.x, player.position.y, zPos);
    }
}

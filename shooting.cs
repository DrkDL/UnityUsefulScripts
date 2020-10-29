using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/*
 * This script clones an already existing GameObject(That has a Rigidbody) inside of the player and shoots it in  
 * the direction the player is facing. Physics between player and bullet is ignored.
 * 
 * 
 * GIVE THIS SCIPT TO PLAYER 
 * 
 * 
 */

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject proj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.LeftShift))
         {
             GameObject bullet = Instantiate(proj, transform.position, transform.rotation) as GameObject;
             bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);
             Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
         }
    }
}

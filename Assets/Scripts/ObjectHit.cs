using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Oh no," + collision.gameObject.name + " hit me :("); //Oh no, Dodgy hit me :(
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
   
    }
}
/*  OnCollisionEnter.
    If box collider touches another box collider, that will signal or trigger an event that says collision took place. 
    Collision collison, aka the parameter in the OnCollisionEnter, says who hit the object

    GetComponent<MeshRenderer>().material.color = Color.red; 
    READ LEFT TO RIGHT
    Unity = "So you want to get a component... You want to access the mesh renderer of the game object. Ok, you accessed the materials and you want to change its color, mhm. Ok, so you want it to be Color red"
 */

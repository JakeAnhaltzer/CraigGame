using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : MonoBehaviour {

    bool checkForAttack; //Used so you cant start an attack while mid attack

    void Start () {
        weaponEnabled(false);
    }

    void FixedUpdate () {
        checkForAttack = this.GetComponent<BoxCollider2D>().enabled; //Updates if youre in an attack or not
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Joystick1Button2)) && checkForAttack == false)
        {
            weaponEnabled(true);
            Invoke("endSwipe", .25f);
            //play animation of sword swipe here
        }
    }

    void endSwipe() //Maybe change this cause its dumb code but it works so
    {
        weaponEnabled(false); //Its cause I can't call invoke in update and pass false as the bool while invoking
    }

    void weaponEnabled(bool swap) //Swaps the weapons sprite and collider. May need to be changed when adding animation
    {
        this.GetComponent<BoxCollider2D>().enabled = swap;
        this.GetComponent<SpriteRenderer>().enabled = swap;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health; //Health is set in the unity editor per each object with health script
	
	public void getHit(int damage) //Need to call this from a script that deals with the colliders 
    {
        health -= damage;
        if (health <= 0 && this.tag != "Player")
            die();
        else if ((health <= 0 && this.tag == "Player"))
            playerDie();
    }

    void die() 
    {
        //Before calling destroy, use this spot to drop any loot such as money or health or anything like that
        Destroy(this.gameObject);
    }

    void playerDie()
    {
        //Call any special things for player death like a game over screen
        Destroy(this.gameObject); //Maybe use this
    }
}

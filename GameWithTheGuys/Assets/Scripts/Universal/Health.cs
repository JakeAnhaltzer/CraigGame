using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    int health;

	// Use this for initialization
	void Start () {
        if (this.tag == "Enemy1")
            health = 4;
        else if (this.tag == "Player")
            health = 5;
	}
	
	public void getHit(int damage) //Need to call this from a script that deals with the colliders 
    {
        health -= damage;
        if (health >= 0 && this.tag != "Player")
            die();
        else
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

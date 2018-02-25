using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D rb;
    private Vector2 direciton;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy" || other.tag == "EnemyAttack")
        {
            this.GetComponent<Health>().getHit(other.GetComponent<Damage>().damageValue); //Damage player
            direciton = transform.position - other.transform.position; //Gets direction so the player bounces off enemy
            direciton.Normalize();
            if(direciton.x >= 0) //for some reason bouncing up is working but not right or left
            {
                rb.AddForce(transform.right * 50, ForceMode2D.Impulse);//also make this less if statement 
            }
            else if (direciton.x < 0)
            {
                rb.AddForce(-transform.right * 35, ForceMode2D.Impulse);
            }
            if (direciton.y >= 0)
            {
                rb.AddForce(transform.up * 25, ForceMode2D.Impulse);
            }
            else if (direciton.y < 0)
            {
                rb.AddForce(-transform.up * 25, ForceMode2D.Impulse);
            }
        }
    }
}

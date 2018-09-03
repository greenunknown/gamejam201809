using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public float speed;
	public bool direction = true;

	protected Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		
		//direction = GetComponent<Player>().facingRight; //GetComponent<Player>().facingRight;

		
		if(direction)
			rb2d.velocity = transform.right * speed;
		else
			rb2d.velocity = transform.right * -1 * speed;

		Debug.Log("\nspeed: " + speed + "\nrb2d.velocity: " + rb2d.velocity + "\n");
	}
		
	private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "KillZone" || other.tag == "Platform" || other.tag == "Projectile")
        {
            Destroy(this);
        }
	}
}

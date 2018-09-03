using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour {
	public int startingHealth = 100;
    public int currentHealth;
    
	public int startingLife = 4;
	public int currentLife;

    protected BoxCollider2D boxCollider;
    protected Rigidbody2D rb2D;

	protected bool isDead;

	// Use this for initialization
	void Start () {
		boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
		currentHealth = startingHealth;
		currentLife = startingLife;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "KillZone")
        {
            Respawn();
        }

		/*
		if (other.tag == "Projectile")
		{
			currentHealth -= projectileDamage;
		}

		if (other.tag == "Player")
		{
			if other player 
		}
		 */

		
    }

	private void Respawn()
	{
		currentLife -= 1;
		transform.position = new Vector2(GameObject.FindGameObjectWithTag("SpawnPoint").transform.position.x, GameObject.FindGameObjectWithTag("SpawnPoint").transform.position.y);
	}

	// Check if the player has died
	private void CheckDeath()
	{
		if(currentHealth < 100)
		{
			Respawn();
		}

		CheckLose();
	}

	// Check if the player has lost
	private void CheckLose()
	{
		if(currentLife < 0)
		{
			Destroy(this);
		}
	}
}

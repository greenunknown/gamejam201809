using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFight : Player {

	public GameObject shot;
	public Transform shotSpawn;
	public float firerate = 0.5f;
	private float nextFire = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Melee attack
		if(Input.GetButtonDown("Fire1") && Time.time > nextFire)
		{
				nextFire = Time.time + firerate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
		// Projectile attack
		if(Input.GetButtonDown("Fire2"))
		{

		}
		// Guard
		if(Input.GetButtonDown("Fire3"))
		{

		}
	}
}

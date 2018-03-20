using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int health;

	public void giveHealth(int extraHealth)
	{
		health += extraHealth;
	}

	public void giveDamage(int damage)
	{
		health -= damage;
	}

	void Death()
	{
		Debug.Log("Player died!");
		Application.Quit();
	}

	void Update()
	{
		if(health <= 0)
			Death();
	}
}

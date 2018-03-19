using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float jumpHeight;
	public float movementSpeed;

	void Update()
	{
		if(Input.GetButtonDown("Jump"))
			StartCoroutine(Jump());
	}

	IEnumerator Jump()
	{
		yield return new WaitForFixedUpdate();
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movementSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}
}

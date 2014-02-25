using UnityEngine;
using System.Collections;

public class PlayerControlCar : MonoBehaviour
{
	public float moveForce = 365f;            // Amount of force added to move the player left and right.
	public float maxSpeed = 5f;                // The fastest the player can travel in the x axis.

	void FixedUpdate ()
	{
		// Cache the horizontal input.
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if(h * rigidbody2D.velocity.x < maxSpeed)
			rigidbody2D.AddForce(Vector2.right * h * moveForce);
		
		if(v * rigidbody2D.velocity.y < maxSpeed)
			rigidbody2D.AddForce(Vector2.up * v * moveForce);
		
		if(Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
			rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		
		if(Mathf.Abs(rigidbody2D.velocity.y) > maxSpeed)
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, Mathf.Sign(rigidbody2D.velocity.y) * maxSpeed);
	}
}
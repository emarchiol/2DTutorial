using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed = 50, jumpVelocity = 150;
	bool isGround = false;
	Transform playerTransf;
	Rigidbody2D playerBody;

	void Start () {
		playerBody = this.GetComponent<Rigidbody2D>();
		playerTransf = this.GetComponent<Transform>();
	}

	void FixedUpdate () {

		//Move with keyboard and joystick
		playerBody.AddForce((Vector2.right * speed) * Input.GetAxis("Horizontal"));
	}

	public void Move(float horizontalInput){

	}
}

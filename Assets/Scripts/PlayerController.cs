using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;// public variables can be accessed in editor
	// default is 0 so needs to be updated

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>(); 
	}
/*	
	// Update is called once per frame
	void Update () {
		
	}
*/
	// FixedUpdate is called before any physics calculations
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		// vec3(x, y, z)
		// y = 0.0f b/c don't want it to move up and down
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);	
	}
}

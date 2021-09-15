using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public float speed = 50f;
	public float jumpForce = 50f;
	public LayerMask groundLayers;
	public CapsuleCollider col;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		col = GetComponent<CapsuleCollider>();
	}

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		rb.AddForce(movement*speed);

		if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
		}

	}
	private bool IsGrounded()
	{
		return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
	}
	void OnTriggerEnter(Collider other)
	{
		
	}
}

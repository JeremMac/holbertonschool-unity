using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public Rigidbody player;
	public Transform resPosition;
	public float speed ;
	public float jumpForce = 10f;
    public bool isGrounded = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Récupération des entrées du joueur
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

		transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
		transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			player.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}
		if (transform.position.y < -30)
		{
			transform.position = resPosition.position;
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			isGrounded = true;
		}
	}
}

using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private CharacterController _controller;
	public Transform resPosition;

	[SerializeField] private float playerSpeed = 5f;
	[SerializeField] private float _rotationSpeed = 10f;
	[SerializeField] private Camera _followCamera;

	private Vector3 _playerVelocity;
	private bool _groundedPlayer;

	public Animator anim;

	[SerializeField] private float _jumpHeight = 3f;
	[SerializeField] private float _gravityValue = -9.81f;

	// Use this for initialization
	void Start () 
	{
		_controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Movement();

		if (transform.position.y < -30)
		{
			transform.position = resPosition.position;
		}
	}


	void Movement()
	{
		_groundedPlayer = _controller.isGrounded;
		if(_groundedPlayer && _playerVelocity.y < 0)
		{
			_playerVelocity.y = 0f;
			anim.SetBool("Jumping", false);
		}
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		Vector3 movementInput = Quaternion.Euler(0, _followCamera.transform.eulerAngles.y, 0) * new Vector3(horizontalInput, 0, verticalInput);
		Vector3 movementDirection = movementInput.normalized;

		_controller.Move(movementDirection * playerSpeed * Time.deltaTime);

		if(movementDirection != Vector3.zero)
			{
				Quaternion desiredRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
				transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, _rotationSpeed * Time.deltaTime);
			}

		bool isRunning = movementDirection.magnitude > 0;
        anim.SetBool("Running", isRunning);

		if(Input.GetButtonDown("Jump") && _groundedPlayer)
		{
			_playerVelocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * _gravityValue);
			anim.SetBool("Jumping", true);
		}

		_playerVelocity.y += _gravityValue * Time.deltaTime;
		_controller.Move(_playerVelocity * Time.deltaTime);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float mouseSensitivity;
	public float smoothTime;
	private float _rotationY;
	private float _rotationX;
	public Transform target;
	public float distanceFromTarget;
	private Vector3 _currentLocation;
	private Vector3 _smoothVelocity = Vector3.zero;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

		_rotationY += mouseX;
		_rotationX += mouseY;

		_rotationX = Mathf.Clamp(_rotationX, -30, 30);

		Vector3 nextRotation = new Vector3(_rotationX, _rotationY);
		//Vector3 playerRotation = new Vector3(0, _rotationY);
		_currentLocation = Vector3.SmoothDamp(_currentLocation, nextRotation, ref _smoothVelocity, smoothTime);

		transform.localEulerAngles = _currentLocation;

		transform.position = target.position - transform.forward * distanceFromTarget;
		target.rotation = transform.rotation;
		//target.rotation = Quaternion.Euler(transform.rotation.x, 0f, 0f);
	}
}

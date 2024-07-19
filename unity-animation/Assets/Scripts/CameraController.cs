using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public static class GameSettings
{
    public static bool isInverted = false;
}
public class CameraController : MonoBehaviour {

	public float mouseSensitivity;
	public float smoothTime;
	private float _rotationY;
	private float _rotationX;
	public Transform target;
	public float distanceFromTarget;
	private Vector3 _currentLocation;
	private Vector3 _smoothVelocity = Vector3.zero;
	public bool isInverted;
	public static CameraController instance;


	// Use this for initialization
	void Start () 
	{
		instance = this;
        isInverted = GameSettings.isInverted;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

		if (isInverted == false)
        {
            _rotationY += mouseX;
            _rotationX -= mouseY;

        }
        else
        {
            _rotationY += mouseX;
            _rotationX += mouseY;
        }

		_rotationX = Mathf.Clamp(_rotationX, -30, 30);

		Vector3 nextRotation = new Vector3(_rotationX, _rotationY);

		_currentLocation = Vector3.SmoothDamp(_currentLocation, nextRotation, ref _smoothVelocity, smoothTime);

		transform.localEulerAngles = _currentLocation;

		transform.position = target.position - transform.forward * distanceFromTarget;
	}
}

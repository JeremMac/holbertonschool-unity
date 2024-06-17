using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour {

	public GameObject timerGameObject;
    private Timer timerScript;

	public bool timerRolling = true;

	// Use this for initialization
	void Start () 
	{
		timerScript = timerGameObject.GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (timerGameObject.transform.position.x != transform.position.x && timerRolling == true)
		{
			timerScript.StartTimer();
		}
		
	}
}

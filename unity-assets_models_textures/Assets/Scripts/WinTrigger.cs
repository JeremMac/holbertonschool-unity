using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour {
	public TimerTrigger timeStop;
	public Text winText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.CompareTag("Player"))
		{
			timeStop.timerRolling = false;
			winText.color = Color.green;
			winText.fontSize = 60;
		}
	}
}

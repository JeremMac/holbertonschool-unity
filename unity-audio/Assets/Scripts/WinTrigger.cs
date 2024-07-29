using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour {
	public TimerTrigger timeStop;
	public TextMeshProUGUI winText;
	public GameObject winCanvas;
	public TextMeshProUGUI winCanvasText;
	public Timer timer;

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
			//winText.color = Color.green;
			//winText.fontSize = 60;
			winCanvas.gameObject.SetActive(true);
			winText.gameObject.SetActive(false);
			Cursor.visible = true;
        	Cursor.lockState = CursorLockMode.None;
			//winCanvasText.text = winText.text;
			timer.Win(winCanvasText, winText);
		}
	}
}

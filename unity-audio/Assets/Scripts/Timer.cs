using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public TextMeshProUGUI TimerText;
	public float currentTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void StartTimer()
	{
		currentTime += Time.deltaTime;
		int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        int centiseconds = Mathf.FloorToInt((currentTime * 100) % 100);
        TimerText.text = string.Format("{0:0}.{1:00}.{2:00}", minutes, seconds, centiseconds);
	}

	public void Win(TextMeshProUGUI text1, TextMeshProUGUI text2)
	{
		text1.text = text2.text;
	}
}

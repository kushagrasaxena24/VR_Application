using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class timer : MonoBehaviour {

	public Text timerText;
	private float startTime;
	// Use this for initialization
	void Start () {
		startTime = 45f;

	}
	
	// Update is called once per frame
	void Update () {
		startTime-=Time.deltaTime;

		UpdateLevelTimer(startTime );
	    

	}

	public void UpdateLevelTimer(float totalSeconds)
	{
		int minutes = Mathf.FloorToInt(totalSeconds / 60f);
		int seconds = Mathf.RoundToInt(totalSeconds % 60f);

		string formatedSeconds = seconds.ToString();

		if (seconds == 60)
		{
			seconds = 0;
			minutes += 1;
		}

		timerText.text = "Time Left: "+ minutes.ToString("00") + ":" + seconds.ToString("00");
	}
}



//public class timer : MonoBehaviour {
//
//	public Text timerText;
//	private float startTime;
//	// Use this for initialization
//	void Start () {
//		startTime = Time.time;
//
//	}
//
//	// Update is called once per frame
//	void Update () {
//		float t = Time.time - startTime;
//
//		string minutes = ((int)t / 60).ToString ();
//		string seconds = ((int)t % 60).ToString ();
//		timerText.text = minutes + ":" + seconds;	
//
//
//	}
//}



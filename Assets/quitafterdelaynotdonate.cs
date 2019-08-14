using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitafterdelaynotdonate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("changescene", 22.0f);
	}

	// Update is called once per frame
	void changescene () {
		SceneManager.LoadScene("quit");

	}
}

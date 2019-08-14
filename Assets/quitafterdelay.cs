using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitafterdelay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("changescene", 15.0f);
	}
	
	// Update is called once per frame
	void changescene () {
		SceneManager.LoadScene("menu");
		
	}
}

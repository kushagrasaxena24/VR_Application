using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyRaycastSelect: RaycastSelect {



	//scenecontroller sc;

	protected override void OnRaycastEnter(GameObject target)
	{

		SceneManager.LoadScene("endgame");
	
	}


	protected override void OnRaycastLeave(GameObject target)
	{
	}
}








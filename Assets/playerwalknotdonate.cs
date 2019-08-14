using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwalknotdonate : MonoBehaviour {



	public int playerSpeed;
		// Use this for initialization
		void Start () {
		StartCoroutine(waiter());
		}

		// Update is called once per frame
		void Update () {
			if (Input.GetButton ("Fire1")) {
				transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
			}
		     
		      
		    
		}

	IEnumerator waiter()
	{
		yield return new WaitForSeconds(19);
		//Rotate 90 deg
		transform.Rotate (new Vector3 (90, 0, 0), Space.World);
	}

	     

}


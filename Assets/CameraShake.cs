using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	

	private float amplitude = 0.1f;
	private float duration = 0.5f;

	private Vector3 initialPosition;

	
	// Use this for initialization
	void Start ()
	{
		
		initialPosition = transform.localPosition;
	}


	
	// Update is called once per frame
	void LateUpdate ()
	{
		

			transform.localPosition = initialPosition + Random.insideUnitSphere*amplitude;

	}
}

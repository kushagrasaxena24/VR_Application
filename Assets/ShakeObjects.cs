using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShakeObjects : MonoBehaviour
{
   
    [SerializeField] GameObject shakeObjects;
   // [SerializeField] float shakeAmount;
   // [SerializeField] float shakeDuration;

    public void Update1()
    {
        shakeObjects = GameObject.Find("Group9");
        Shake(shakeObjects, 0.09f, 100);

    }

    public void Update2()
    {
        shakeObjects = GameObject.Find("Group9");
        Shake(shakeObjects, 0, 0);

    }

    public void Shake(GameObject shakeObjects, float shakeAmount, float shakeDuration)
    {
        

         iTween.ShakePosition(shakeObjects, Vector3.one * shakeAmount, shakeDuration);
              
    }
}

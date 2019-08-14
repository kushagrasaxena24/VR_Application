using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAdvanced : MonoBehaviour
{
   public GameObject gameObject;
    public GameObject gameObject2;

    public GameObject gameObject3;
    public void DestroyGameObject()
    {
        Destroy(gameObject);

        Destroy(gameObject2);

        Destroy(gameObject3);

    }
}

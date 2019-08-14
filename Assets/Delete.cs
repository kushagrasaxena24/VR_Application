using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
   public GameObject gameObject;
   public void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callanotherscript : MonoBehaviour

{

    public GameObject shaker;
    // Start is called before the first frame update
    void Start()
    {
        ShakeObjects shake = shaker.GetComponent<ShakeObjects>();
       //shake.Shake(shaker);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

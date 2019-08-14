using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WastedWater : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneToLoad; 
    public void goToBadFuture()
    {
         SceneManager.LoadScene(sceneToLoad);
    }
}

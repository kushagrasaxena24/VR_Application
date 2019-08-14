using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinalMessage : MonoBehaviour
{
   public string sceneToLoad;
    public void goToGoodFuture()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

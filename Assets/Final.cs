using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Final : MonoBehaviour
{
  public string sceneToLoad;
    public void goToFuture()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

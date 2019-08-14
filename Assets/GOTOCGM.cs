using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GOTOCGM : MonoBehaviour
{
    public string sceneToLoad;
    public void goToVR()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
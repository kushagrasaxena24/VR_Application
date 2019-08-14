using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SavedWater : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneToLoad;
    public void goToGoodFuture()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}

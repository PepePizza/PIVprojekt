using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapScript : MonoBehaviour
{
    public string sceneToLoad;

    public void LoadSceneOnClick()
    {
    SceneManager.LoadScene(sceneToLoad);
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class LoadSceneOnClick : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene (sceneIndex);
    }


}

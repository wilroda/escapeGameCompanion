using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }

    public void SceneLoad(int sceneANumber)
    {
        SceneManager.LoadScene(sceneANumber);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARSceneManager : MonoBehaviour
{
    public void GotoScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

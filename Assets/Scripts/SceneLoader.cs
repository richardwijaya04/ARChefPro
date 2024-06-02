using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("MainMenu2");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("ImageTargetMM");
    }

    public void LoadNextInBuild()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

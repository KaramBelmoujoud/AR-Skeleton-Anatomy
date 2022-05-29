using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Homefrom2 : MonoBehaviour
{

    public void PlayGame(string scene)
    {
        SceneManager.LoadScene(scene);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("main");
    }
    public void exit()
    {
        Application.Quit();
    }
    public void Menu()
    {
         SceneManager.LoadScene("FirstScene");
    }
    public void Restart()
    {
        SceneManager.LoadScene("main");
    }
}

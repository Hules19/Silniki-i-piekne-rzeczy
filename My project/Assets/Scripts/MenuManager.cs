using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private bool _fadein = false;
    private bool _fadeout = false;

    public float TimeToFade;
    public float TimeToChangeScene;
  
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Exit()
    {
        Application.Quit();
    } 

}
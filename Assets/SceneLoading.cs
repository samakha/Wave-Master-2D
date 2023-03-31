using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneLoading : MonoBehaviour
{
   public void GotoPlayScene()
    {
        SceneManager.LoadScene("MainScene"); 
    }
    public void GotoAboutUsScene()
    {
        SceneManager.LoadScene("AboutUsScene");
    }
    public void GotoAboutThisGameScene()
    {
        SceneManager.LoadScene("AboutThisGameScene");
    }
    public void GotoMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void PressedPrivacy(string link)
    {
        Application.OpenURL(link); 
    }
}

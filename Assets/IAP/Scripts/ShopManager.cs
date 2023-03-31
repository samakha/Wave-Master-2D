using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    [SerializeField] GameObject Content;

    [SerializeField] IAP_Manager IAP_Manager;

    public string ScenePlay;

    public void Show()
    {
        if (IAP_Manager.CanShowShop())
        {
            Content.SetActive(true);
        }
        Content.SetActive(true);
        Time.timeScale = 0; 
    }

    public void Hide()
    {
        Content.SetActive(false);
        Time.timeScale = 1;
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene(ScenePlay);
    }
}

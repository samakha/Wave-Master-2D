using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController_wave : MonoBehaviour
{
    public GameObject gameOverPanel;

    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI startText;

    int currentScore;
    public GameObject panel_loading;

    void Start()
    {
        currentScore = 0;
        bestScoreText.text = PlayerPrefs.GetInt("BestScore_wave", 0).ToString();
        SetScore();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            startText.gameObject.SetActive(false);
        }
    }

    public void CallGameOver()
    {
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.5f);
        gameOverPanel.SetActive(true);
       // AdManager.instance.show_ads_ingames();
        yield break;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddScore()
    {
        currentScore++;
        if(currentScore > PlayerPrefs.GetInt("BestScore_wave", 0))
        {
            PlayerPrefs.SetInt("BestScore_wave", currentScore);
            bestScoreText.text = currentScore.ToString();
        }
        SetScore();
    }

    void SetScore()
    {
        currentScoreText.text = currentScore.ToString();
    }
    public void click_menu()
    {
       panel_loading.SetActive(true);
       SceneManager.LoadSceneAsync(0 , LoadSceneMode.Single); 
    }
}

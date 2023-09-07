using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject Zigzag;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI HighScore1;
    public TextMeshProUGUI HighScore2;
    public GameObject core;
    void Awake()
    {
        if(instance == null)
        {
            instance=this;
        }
    }
    void Start()
    {
        HighScore1.text= "High Score: " + PlayerPrefs.GetInt("HighScore");
    }
    public void GameStart()
    {
        tapText.SetActive(false);
        Zigzag.GetComponent<Animator>().Play("PanelUp");
        core.SetActive(true);
    }
    public void GameOver()
    {
        Score.text = PlayerPrefs.GetInt("Score").ToString();
        HighScore2.text= PlayerPrefs.GetInt("HighScore").ToString();
        gameOverPanel.SetActive(true);
    }
    public void reset()
    {
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        
    }
}

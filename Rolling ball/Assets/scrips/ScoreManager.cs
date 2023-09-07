using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int Score;
    public int HighScore;
    public TextMeshProUGUI core;
    void Awake()
    {
        if(instance == null)
        {
            instance=this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void inScore()
    {
        //Score+=1;
        core.text = "Score: " + Score;
    }
    public void StartScore()
    {
        Score=0;
        PlayerPrefs.GetInt("Score",Score);
        InvokeRepeating("inScore",0.1f,0.5f);
    }
    public void StopScore()
    {
        CancelInvoke("inScore");
        PlayerPrefs.SetInt("Score",Score);
        if(PlayerPrefs.HasKey("HighScore"))
        {
             if(Score> PlayerPrefs.GetInt("HighScore"))
             {
                PlayerPrefs.SetInt("HighScore",Score);
             }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore",Score);
        }
    }
}

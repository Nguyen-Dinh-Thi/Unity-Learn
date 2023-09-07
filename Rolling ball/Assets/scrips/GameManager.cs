using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;
    void Awake()
    {
        if(instance == null)
        {
            instance=this;
        }
    }
    void Start()
    {
        gameOver=false;
    }
    void Update()
    {
        
    }
    public void StartGame()
    {
        UIManager.instance.GameStart();
        ScoreManager.instance.Score=0;
        ScoreManager.instance.StartScore();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().StartSpawn();
    }
    public void GameOver()
    {
        UIManager.instance.GameOver();
        ScoreManager.instance.StopScore();
        gameOver=true;
    }
}

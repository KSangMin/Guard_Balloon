using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    public GameObject obstacle;

    private float _time;
    public Text timeText;
    public Text nowScore;
    public Text bestScore;

    bool isPlaying = true;

    public GameObject endPanel;

    private string key = "bestScore";

    public Animator balloonAnim;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Time.timeScale = 1f;
        InvokeRepeating("CreateObstacle", 0f, 1f);
    }

    void Update()
    {
        if(isPlaying) 
        {
            _time += Time.deltaTime;
            timeText.text = _time.ToString("N1");
        }
    }

    public void CreateObstacle()
    {
        Instantiate(obstacle);
    }

    public void GameOver()
    {
        isPlaying = false;
        nowScore.text = _time.ToString("N1");
        if (!PlayerPrefs.HasKey(key) || _time > PlayerPrefs.GetFloat(key))
        {
            PlayerPrefs.SetFloat(key, _time);
        }
        bestScore.text = PlayerPrefs.GetFloat(key).ToString("N1");
    }

    public void TimeStop()
    {
        endPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}

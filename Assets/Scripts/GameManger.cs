using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public GameObject obstacle;

    private float _time;
    public Text timeText;

    void Start()
    {
        InvokeRepeating("CreateObstacle", 0f, 1f);
    }

    void Update()
    {
        _time += Time.deltaTime;
        timeText.text = _time.ToString("N1");
    }

    public void CreateObstacle()
    {
        Instantiate(obstacle);
    }
}

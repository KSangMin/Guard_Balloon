using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateObstacle()
    {
        Instantiate(obstacle);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-3f, 3f);
        float y = Random.Range(3f, 5f);
        float scale = Random.Range(0.5f, 1.5f);

        transform.position = new Vector2(x, y);
        transform.localScale = new Vector2(scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManger.Instance.balloonAnim.SetBool("isDead", true); ;
            GameManger.Instance.GameOver();
        }
    }
}

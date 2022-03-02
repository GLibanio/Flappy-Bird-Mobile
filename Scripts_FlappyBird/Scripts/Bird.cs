using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Game_Controller Controller;
    public float speed = 2f;
    Rigidbody2D rig;
    public GameObject GameOver;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Began)
            {
                rig.velocity = Vector2.up * speed;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}

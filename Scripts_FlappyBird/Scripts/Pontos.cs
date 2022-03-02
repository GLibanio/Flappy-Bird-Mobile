using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    Game_Controller Controller;

    private void Start()
    {
        Controller = FindObjectOfType<Game_Controller>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Controller.Score++;
        Controller.Pontos.text = Controller.Score.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game_Controller : MonoBehaviour
{
    public GameObject Menu;
    public TextMeshProUGUI Pontos;
    public TextMeshProUGUI Recorde;
    public int Score;
    public static int Recorde_Contador;
    void Start()
    {
        Menu.SetActive(true);
        Time.timeScale = 0;
    }
    private void Update()
    {
        if(Score > Recorde_Contador)
        {
            Recorde_Contador = Score;
        }
        Recorde.text = Recorde_Contador.ToString();
    }
    public void resetarGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Começar()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
    }
}

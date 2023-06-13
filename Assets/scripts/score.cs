using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{

    public int Scorecount;
    public Text scoreText;
    public GameObject gameover;

    
    void Start()
    {

      
        

    }
    void Update()
    {
        scoreText.text = Scorecount.ToString();
    }



    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameover.SetActive(true);
    }

      
}

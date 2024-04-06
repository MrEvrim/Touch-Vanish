using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
   public  GameObject restartBtn;
    int score = 0;

    void Update()
    {
        
    }

    public void ScoreUp()
    {
        score++;

        if (score >= 4)
        {
            Win();
        }
    }
    void Win()
    {
        winText.SetActive(true);
        restartBtn.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}

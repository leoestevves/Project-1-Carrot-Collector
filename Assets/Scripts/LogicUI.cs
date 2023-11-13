using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LogicUI : MonoBehaviour
{
    [SerializeField] GameObject GameOverScreen;
    [SerializeField] Player _Player; 

    // Update is called once per frame
    void FixedUpdate()
    {
        GameOver();
    }

    void GameOver()
    {
        if(_Player.score >= _Player.winScore)
        {
            GameOverScreen.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

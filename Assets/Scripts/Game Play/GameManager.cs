using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    

    bool gameHasEnded = false;
    public float restartDelay = 0;
    public static GameManager instance;


    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);       
            GameOver(); ;
            
        }
      
    }


    public void Restart()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameHasEnded = false;
    }
     


}



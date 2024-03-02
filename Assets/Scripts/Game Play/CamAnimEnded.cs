using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CamAnimEnded : MonoBehaviour
{
    public Animator animator;
    public static bool animationPlayed = false;
    private int levelNum = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex != levelNum && animationPlayed)
        {
            // play a "level transition" animation if desired
        }
        else if (scene.buildIndex != levelNum && !animationPlayed)
        {
            // play a "level transition" animation if desired
            animationPlayed = true;
            levelNum = scene.buildIndex;
        }
        else if (scene.buildIndex == levelNum && !animationPlayed)
        {
            animator.Play("Camera 1st Level");
            animationPlayed = true;
        }
    }

    // Other camera controller code...
}









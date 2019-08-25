using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool isEndGame = false;

    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;

    public void EndGame()
    {
        if (isEndGame)
            return;

        isEndGame = true;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void RetryLevel()
    {
        //FindObjectOfType<spawnJudge>().JudgeSpawn();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

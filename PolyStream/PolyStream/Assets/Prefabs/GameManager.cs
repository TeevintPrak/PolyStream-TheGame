using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int money;
    static public bool levelComplete = true;
    bool collectedGM;
 
    bool gameOver = false;
    public GameObject levelCompleteUI;
    public GameObject deathUI;
    public float restartDelay = 0.1f;
    public int deathCount1 = 0;
    public int deathCount2 = 0;
    public int deathCount3 = 0;
    public int attemptCount1 = 0;
    public int attemptCount2 = 0;
    public int attemptCount3 = 0;
    public int completionLevel1 = 0; //0 = false, 1 = true
    public int completionLevel2 = 0;
    public int completionLevel3 = 0;
    public float currentTime1 = 0;
    public float currentTime2 = 0;
    public float currentTime3 = 0;
    public float[] currentTime = new float[3];
    public float[] bestTime = new float[3];
    public int[] levelCompletions = new int[3];


    public void Start()
    {
   
        money = PlayerPrefs.GetInt("Money");
        completionLevel1 = PlayerPrefs.GetInt("completionLevel1");
        completionLevel2 = PlayerPrefs.GetInt("completionLevel2");
        completionLevel3 = PlayerPrefs.GetInt("completionLevel3");
    }

    public void FixedUpdate()
    {
        money = PlayerPrefs.GetInt("Money");
        deathCount1 = PlayerPrefs.GetInt("deathCount1");
        deathCount2 = PlayerPrefs.GetInt("deathCount2");
        deathCount3 = PlayerPrefs.GetInt("deathCount3");
        completionLevel1 = PlayerPrefs.GetInt("completionLevel1");
        completionLevel2 = PlayerPrefs.GetInt("completionLevel2");
        completionLevel3 = PlayerPrefs.GetInt("completionLevel3");
        attemptCount1 = PlayerPrefs.GetInt("attemptCount1");
        attemptCount2 = PlayerPrefs.GetInt("attemptCount2");
        attemptCount3 = PlayerPrefs.GetInt("attemptCount3");
    }
    // Start is called before the first frame update
    public void InvokeGameOver()
    {
        levelComplete = false;
        Invoke("GameOver", restartDelay);
    }

    public void BestTime(float time, int scene)
    {
        
        int scene1 = scene - 1;
        if (scene == 1 && levelCompletions[scene1] <= 1)
        {
            currentTime[0] = time;
            Debug.Log("currentTime [0]: " + time);
        }
        else if (scene == 2 && levelCompletions[scene1] <= 1)
        {
            currentTime[1] = time;
        }
        else if (scene == 3 && levelCompletions[scene1] <= 1)
        {
            currentTime[2] = time;
        }
        else if (currentTime[scene1] <= time && currentTime[scene1] != 0)
        {
            bestTime[scene1] = currentTime[scene1];
        }

        if (scene == 1)
        {
            currentTime[scene1] = PlayerPrefs.GetFloat("currentTime1", currentTime[scene1]);
        }
        else if (scene == 2)
        {
            currentTime[scene1] = PlayerPrefs.GetFloat("currentTime2", currentTime[scene1]);
        }
        else if (scene == 3)
        {
            currentTime[scene1] = PlayerPrefs.GetFloat("currentTime3", currentTime[scene1]);
        }

        if (currentTime[scene1] >= time)
        {
            bestTime[scene1] = time;
            currentTime[scene1] = bestTime[scene1];
            if (scene == 1)
            {
                PlayerPrefs.SetFloat("currentTime1", currentTime[scene1]);
            }
            else if (scene == 2)
            {
                PlayerPrefs.SetFloat("currentTime2", currentTime[scene1]);
            }
            else if (scene == 3)
            {
                PlayerPrefs.SetFloat("currentTime3", currentTime[scene1]);
            }
        }
        else if (currentTime[scene1] <= time && currentTime[scene1] != 0)
        {
            bestTime[scene1] = currentTime[scene1];
        }
        Debug.Log("currentTime :" + currentTime[scene1]);
        Debug.Log("Best Time :" + bestTime[scene1]);
        FindObjectOfType<BestTimer>().SetBestTime(bestTime[scene1], scene);
    }

    public void ResetTime(int scene)
    {
        FindObjectOfType<Timer>().ResetTimer(scene);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("Money", money);
    }

    public void SaveMoney()
    {
        PlayerPrefs.SetInt("Money", money);
    }

    public void DeathCounter()
    {
        AttemptCounter();
        Debug.Log(deathCount1);
        int sceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (sceneNumber == 1)
        {
            deathCount1 += 1;
            PlayerPrefs.SetInt("deathCount1", deathCount1);
        }
        else if (sceneNumber == 2)
        {
            deathCount2 += 1;
            PlayerPrefs.SetInt("deathCount2", deathCount2);
        }
        else if (sceneNumber == 3)
        {
            deathCount3 += 1;
            PlayerPrefs.SetInt("deathCount3", deathCount3);
        }
    }

    public void AttemptCounter()
    {
        int sceneNumber = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("attemp sceneNumber = " + sceneNumber);
        int level1Completed = PlayerPrefs.GetInt("completionLevel1");
        int level2Completed = PlayerPrefs.GetInt("completionLevel2");
        int level3Completed = PlayerPrefs.GetInt("completionLevel3");

        if (level1Completed == 0)
        {
            if (sceneNumber == 1)
            {
                Debug.Log(attemptCount1);
                attemptCount1 += 1;
                PlayerPrefs.SetInt("attemptCount1", attemptCount1);
            }
        }
        else
        if (level2Completed == 0)
        {
            if (sceneNumber == 2)
            {
                attemptCount2 += 1;
                PlayerPrefs.SetInt("attemptCount2", attemptCount2);
                Debug.Log("attemp2 attempted");
            }
        }
        else
        if (level3Completed == 0)
        {
            if (sceneNumber == 3)
            {
                attemptCount3 += 1;
                PlayerPrefs.SetInt("attemptCount3", attemptCount3);
            }
        }
    }

    public void ResetEverything()
    {
        ResetMoney();
        for (int i = 0; i < levelCompletions.Length; i++)
        {
            levelCompletions[i] = 0;
        }
        deathCount1 = 0;
        deathCount2 = 0;
        deathCount3 = 0;
        completionLevel1 = 0;
        completionLevel2 = 0;
        completionLevel3 = 0;
        attemptCount1 = 0;
        attemptCount2 = 0;
        attemptCount3 = 0;
        PlayerPrefs.SetInt("completionLevel1",0);
        PlayerPrefs.SetInt("completionLevel2",0);
        PlayerPrefs.SetInt("completionLevel3",0);
        PlayerPrefs.SetInt("attemptCount1", 0);
        PlayerPrefs.SetInt("attemptCount2", 0);
        PlayerPrefs.SetInt("attemptCount3", 0);
        PlayerPrefs.SetInt("deathCount1", 0);
        PlayerPrefs.SetInt("deathCount2", 0);
        PlayerPrefs.SetInt("deathCount3", 0);
    }
    

    public void GameOver()
    {
        if (gameOver == false)
        {
            deathUI.SetActive(true);
            gameOver = true;
        }
    }

    public void ResetMoney()
    {
        money = 0;
        PlayerPrefs.SetInt("Money", money);
    }

    public void AddCoins(int amount)
    {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
    }

    public void SubtractCoins(int amount)
    {
        money = PlayerPrefs.GetInt("Money");
        money -= amount;
        PlayerPrefs.SetInt("Money", money);
    }

    public int MoneyValue()
    {
        return PlayerPrefs.GetInt("Money");
    }

    public void CompleteLevelUI()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        levelCompleteUI.SetActive(true);
        levelCompletions[scene - 1] += 1;
        LevelCompleteChecker();
        FindObjectOfType<Timer>().StopTimer(scene);
        float timeGet = FindObjectOfType<Timer>().GetTime(scene);
        Debug.Log("Get Time: " + timeGet);
        BestTime(timeGet, scene);
        levelComplete = true;
    }

    public void LevelCompleteChecker()
    {
        int sceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (sceneNumber == 1)
        {
            attemptCount1 = PlayerPrefs.GetInt("attemptCount1");
            attemptCount1 += 1;
            PlayerPrefs.SetInt("attemptCount1",attemptCount1);
            completionLevel1 = 1;
            PlayerPrefs.SetInt("completionLevel1", completionLevel1);
        }
        else if (sceneNumber == 2)
        {
            attemptCount2 = PlayerPrefs.GetInt("attemptCount2");
            attemptCount2 += 1;
            PlayerPrefs.SetInt("attemptCount2", attemptCount1);
            completionLevel2 = 1;
            PlayerPrefs.SetInt("completionLevel2", completionLevel2);
        }
        else if (sceneNumber == 3)
        {
            attemptCount3 = PlayerPrefs.GetInt("attemptCount3");
            attemptCount3 += 1;
            PlayerPrefs.SetInt("attemptCount3", attemptCount3);
            completionLevel3 = 1;
            PlayerPrefs.SetInt("completionLevel3", completionLevel3);
        }
    }
}


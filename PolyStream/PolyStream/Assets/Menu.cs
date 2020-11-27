using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadMenu()
    {
        FindObjectOfType<GameManager>().SaveMoney();
        SceneManager.LoadScene(0);
    }
    public void LoadLevel1()
    {
        FindObjectOfType<GameManager>().SaveMoney();
        SceneManager.LoadScene(1);
    }
    public void LoadLevel2()
    {
        FindObjectOfType<GameManager>().SaveMoney();
        SceneManager.LoadScene(2);
    }
    public void LoadLevel3()
    {
        FindObjectOfType<GameManager>().SaveMoney();
        SceneManager.LoadScene(3);
    }
    public void LoadCredits()
    {
        FindObjectOfType<GameManager>().SaveMoney();
        SceneManager.LoadScene(4);
    }

    public void LoadLevelSelect()
    {
        FindObjectOfType<GameManager>().SaveMoney();
        SceneManager.LoadScene(5);
    }

    public void LoadStore()
    {
        FindObjectOfType<GameManager>().SaveMoney();
        SceneManager.LoadScene(6);
    }
	
	public void RestartLevel()
	{
		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene);
	}

    public void NextLevel()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        FindObjectOfType<GameManager>().ResetTime(scene);
        SceneManager.LoadScene(scene+1);
    }

    public void Exit()
    {
		Application.Quit();
    }

    public void ResetMoney()
    {
        FindObjectOfType<GameManager>().ResetMoney();
        FindObjectOfType<GameManager>().ResetEverything();
        FindObjectOfType<Market>().ResetMarket();
    }
}

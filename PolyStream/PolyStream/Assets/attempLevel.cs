using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class attempLevel : MonoBehaviour
{
    public Text a1;
    int a1I;
    // Start is called before the first frame update
    void Start()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 1)
        {
            a1I = FindObjectOfType<GameManager>().attemptCount1;
        }
        else if (scene == 2)
        {
            a1I = FindObjectOfType<GameManager>().attemptCount2;
        }
        else if (scene == 3)
        {
            a1I = FindObjectOfType<GameManager>().attemptCount3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 1)
        {
            a1I = FindObjectOfType<GameManager>().attemptCount1;
        }
        else if (scene == 2)
        {
            a1I = FindObjectOfType<GameManager>().attemptCount2;
        }
        else if (scene == 3)
        {
            a1I = FindObjectOfType<GameManager>().attemptCount3;
        }
        a1.text = a1I.ToString();
    }
}

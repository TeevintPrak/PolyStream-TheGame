using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attemptCounter : MonoBehaviour
{
    public Text a1;
    public Text a2;
    public Text a3;
    public Text d1;
    public Text d2;
    public Text d3;
    int a1I;
    int a2I;
    int a3I;
    int d1I;
    int d2I;
    int d3I;
    // Start is called before the first frame update
    void Start()
    {
        a1I = FindObjectOfType<GameManager>().attemptCount1;
        a2I = FindObjectOfType<GameManager>().attemptCount2;
        a3I = FindObjectOfType<GameManager>().attemptCount3;
        d1I = FindObjectOfType<GameManager>().deathCount1;
        d2I = FindObjectOfType<GameManager>().deathCount2;
        d3I = FindObjectOfType<GameManager>().deathCount3;
    }

    // Update is called once per frame
    void Update()
    {
        a1I = FindObjectOfType<GameManager>().attemptCount1;
        a2I = FindObjectOfType<GameManager>().attemptCount2;
        a3I = FindObjectOfType<GameManager>().attemptCount3;
        a1.text = a1I.ToString();
        a2.text = a2I.ToString();
        a3.text = a3I.ToString();
        d1I = FindObjectOfType<GameManager>().deathCount1;
        d2I = FindObjectOfType<GameManager>().deathCount2;
        d3I = FindObjectOfType<GameManager>().deathCount3;
        d1.text = d1I.ToString();
        d2.text = d2I.ToString();
        d3.text = d3I.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCounterUI : MonoBehaviour
{
    public Text coinsUI;
    public GameManager gm;
    int coins;
    string coinsStr;

    // Start is called before the first frame update
    void Start()
    {
        coins = gm.money;
        coinsUI.text = coins.ToString();
    }

    void FixedUpdate()
    {
        coins = gm.money;
        coinsUI.text = coins.ToString();
    }
}

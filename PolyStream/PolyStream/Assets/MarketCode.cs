using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketCode : MonoBehaviour
{

    public int Buy(int cost)
    {

        int currentMoney = FindObjectOfType<GameManager>().MoneyValue();
        if (currentMoney >= cost)
        {
            FindObjectOfType<GameManager>().SubtractCoins(cost);
            FindObjectOfType<GameManager>().SaveMoney();
            Debug.Log("Subtracted");
            return 1;
        }
        else
        {
            return 0;
        }
    }
}

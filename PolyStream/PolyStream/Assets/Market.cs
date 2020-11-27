using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    // Start is called before the first frame update
    int boughtRed = 0; //0 is false, 1 is true
    int boughtGreen = 0;
    int boughtYellow = 0;
    int boughtOrange = 0;
    int boughtBlack = 0;
    int boughtIndigo = 0;
    int boughtWhite = 0;

    public Color red;
    public Color green;
    public Color yellow;
    public Color orange;
    public Color indigo;
    Color white = Color.white;
    Color black = Color.black;
    public Color original;

    int redPrice = 5;
    int greenPrice = 5;
    int yellowPrice = 5;
    int orangePrice = 10;
    int blackPrice = 20;
    int indigoPrice = 15;
    int whitePrice = 100;

    public void Start()
    {
        boughtRed = PlayerPrefs.GetInt("boughtRed");
        boughtGreen = PlayerPrefs.GetInt("boughtGreen");
        boughtYellow = PlayerPrefs.GetInt("boughtYellow");
        boughtOrange = PlayerPrefs.GetInt("boughtOrange");
        boughtBlack = PlayerPrefs.GetInt("boughtBlack");
        boughtIndigo = PlayerPrefs.GetInt("boughtIndigo");
        boughtWhite = PlayerPrefs.GetInt("boughtWhite");
    }
    public void Update()
    {
        boughtRed = PlayerPrefs.GetInt("boughtRed");
        boughtGreen = PlayerPrefs.GetInt("boughtGreen");
        boughtYellow = PlayerPrefs.GetInt("boughtYellow");
        boughtOrange = PlayerPrefs.GetInt("boughtOrange");
        boughtBlack = PlayerPrefs.GetInt("boughtBlack");
        boughtIndigo = PlayerPrefs.GetInt("boughtIndigo");
        boughtWhite = PlayerPrefs.GetInt("boughtWhite");
    }

    // Update is called once per frame
    public void BuyRed()
    {
        if (boughtRed == 0)
        {
            boughtRed = FindObjectOfType<MarketCode>().Buy(redPrice);
            PlayerPrefs.SetInt("boughtRed", boughtRed);
        }
        else if (boughtRed == 1)
        {
            FindObjectOfType<PlayerColor>().SetColor(red);
        }
    }
    public void BuyGreen()
    {
        if (boughtGreen == 0)
        {
            boughtGreen = FindObjectOfType<MarketCode>().Buy(greenPrice);
            PlayerPrefs.SetInt("boughtGreen", boughtGreen);
        }
        else if (boughtGreen == 1)
        {
            FindObjectOfType<PlayerColor>().SetColor(green);
        }
    }
    public void BuyYellow()
    {
        if (boughtYellow == 0)
        {
            boughtYellow = FindObjectOfType<MarketCode>().Buy(yellowPrice);
            PlayerPrefs.SetInt("boughtYellow", boughtYellow);
        }
        else if (boughtYellow == 1)
        {
            FindObjectOfType<PlayerColor>().SetColor(yellow);
        }
    }
    public void BuyOrange()
    {
        if (boughtOrange == 0)
        {
            boughtOrange = FindObjectOfType<MarketCode>().Buy(orangePrice);
            PlayerPrefs.SetInt("boughtOrange", boughtOrange);
        }
        else if (boughtOrange == 1)
        {
            FindObjectOfType<PlayerColor>().SetColor(orange);
        }
    }
    public void BuyBlack()
    {
        if (boughtBlack == 0)
        {
            boughtBlack = FindObjectOfType<MarketCode>().Buy(blackPrice);
            PlayerPrefs.SetInt("boughtBlack", boughtBlack);
        }
        else if (boughtBlack == 1)
        {
            FindObjectOfType<PlayerColor>().SetColor(black);
        }
    }
    public void BuyIndigo()
    {
        if (boughtIndigo == 0)
        {
            boughtIndigo = FindObjectOfType<MarketCode>().Buy(indigoPrice);
            PlayerPrefs.SetInt("boughtIndigo", boughtIndigo);
        }
        else if (boughtIndigo == 1)
        {
            FindObjectOfType<PlayerColor>().SetColor(indigo);
        }
    }
    public void BuyWhite()
    {
        if (boughtWhite == 0)
        {
            boughtWhite = FindObjectOfType<MarketCode>().Buy(whitePrice);
            PlayerPrefs.SetInt("boughtWhite", boughtWhite);
        }
        else if (boughtWhite == 1)
        {
            FindObjectOfType<PlayerColor>().SetColor(white);
        }    
    }

    public void ResetMarket()
    {
        PlayerPrefs.SetInt("boughtRed",0);
        PlayerPrefs.SetInt("boughtGreen",0);
        PlayerPrefs.SetInt("boughtYellow",0);
        PlayerPrefs.SetInt("boughtOrange",0);
        PlayerPrefs.SetInt("boughtBlack",0);
        PlayerPrefs.SetInt("boughtIndigo",0);
        PlayerPrefs.SetInt("boughtWhite",0);
        FindObjectOfType<PlayerColor>().SetColor(original);
    }
    

    public void SetOriginal()
    {
        FindObjectOfType<PlayerColor>().SetColor(original);
        FindObjectOfType<GameManager>().AddCoins(10);
        FindObjectOfType<GameManager>().SaveMoney();
    }
}

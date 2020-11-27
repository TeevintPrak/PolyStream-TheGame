using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public Material mat;
    public Color red;
    public Color green;
    public Color yellow;
    public Color orange;
    public Color indigo;
    public Color original;
    public Color currentColor;

    public int redID = 0;
    public int greenID = 1;
    public int yellowID = 2;
    public int orangeID = 3;
    public int blackID = 4;
    public int indigoID = 5;
    public int whiteID = 6;
    public int originalID = 7;
    int colorID = 7;

    // Start is called before the first frame update
    void Start()
    {
        /* Color[] color = {
          red,
          yellow,
          green,
          orange,
          indigo,
          Color.black,
          Color.white,
          original,
         };
         int[] colors = { 0, 1, 2, 3, 4, 5, 6, 7 }; */
        colorID = PlayerPrefs.GetInt("ColorID", colorID);
        Debug.Log("Color ID = " + colorID);
        if (colorID == redID)
        {
            mat.SetColor("_Color", red);
        }
        else if (colorID == yellowID)
        {
            mat.SetColor("_Color", yellow);
        }
        else if (colorID == greenID)
        {
            mat.SetColor("_Color", green);
        }
        else if (colorID == orangeID)
        {
            mat.SetColor("_Color", orange);
        }
        else if (colorID == blackID)
        {
            mat.SetColor("_Color", Color.black);
        }
        else if (colorID == indigoID)
        {
            mat.SetColor("_Color", indigo);
        }
        else if (colorID == whiteID)
        {
            mat.SetColor("_Color", Color.white);
        }
        else if (colorID == originalID)
        {
            mat.SetColor("_Color", original);
        }
    }

    public void Update()
    {
        Debug.Log("Color ID = " + colorID);
    }

    public void OnDestroy()
    {
        PlayerPrefs.SetInt("ColorID", colorID); 
    }
    public void SetColor(Color color)
    {
        mat.SetColor("_Color", color);
        if (color == red)
        {
            colorID = redID;
            PlayerPrefs.SetInt("ColorID", colorID);
            Debug.Log("Color = "+ colorID);
        }
        else if (color == yellow)
        {
            colorID = yellowID;
            PlayerPrefs.SetInt("ColorID", colorID);
            Debug.Log("Color = "+ colorID);
        }
        else if (color == green)
        {
            colorID = greenID;
            PlayerPrefs.SetInt("ColorID", colorID);
            Debug.Log("Color = "+ colorID);
        }
        else if (color == orange)
        {
            colorID = orangeID;
            PlayerPrefs.SetInt("ColorID", colorID);
            Debug.Log("Color = "+ colorID);
        }
        else if (color == Color.black)
        {
            colorID = blackID;
            PlayerPrefs.SetInt("ColorID", colorID);
            Debug.Log("Color = " + colorID);
        }
        else if (color == indigo)
        {
            colorID = indigoID;
            PlayerPrefs.SetInt("ColorID", colorID);
            Debug.Log("Color = " + colorID);
        }
        else if (color == Color.white)
        {
            colorID = whiteID;
            PlayerPrefs.SetInt("ColorID", colorID);
            Debug.Log("Color = " + colorID);
        }
        else if (color == original)
        {
            colorID = originalID;
            PlayerPrefs.SetInt("ColorID", colorID);
            Debug.Log("Color = " + colorID);
        }
    }
    /*
    // Update is called once per frame
    public void SetRed() //0
    {
        rend.material.SetColor("_Color", red);
        color = greenID;
    }

    public void SetYellow() //1
    {
        rend.material.SetColor("_Color", yellow);
        color = yellowID;
    }

    public void SetGreen() //2
    {
        rend.material.SetColor("_Color", green);
        color = greenID;
    }

    public void SetOrange() //3
    {
        rend.material.SetColor("_Color", orange);
        color = orangeID;
    }

    public void SetBlack() //4
    {
        rend.material.SetColor("_Color", Color.black);
        color = blackID;
    }

    public void SetIndigo() //5
    {
        rend.material.SetColor("_Color", indigo);
        color = indigoID;
    }

    public void SetWhite() //6
    {
        rend.material.SetColor("_Color", Color.white);
        color = whiteID;
    }

    public void SetOriginal() //7
    {
        rend.material.SetColor("_Color", original);
        color = originalID;
    }*/
}

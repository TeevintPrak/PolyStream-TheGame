using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpCoolDownUI : MonoBehaviour
{
    public GameObject player;
    public Text jumpCoolDownUI;
    PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        /* float currentTime = playerMovement.cooldownTime;
        if (playerMovement.jump == true)
        {
            while (currentTime != 0)
            {
                currentTime = playerMovement.cooldownTime -= 1 * Time.deltaTime;
                //string currentTimeS = currentTime.ToString("0");
                jumpCoolDownUI.text = "|Jump Cool Down = " + currentTime.ToString("0") + " |";
            }
            jumpCoolDownUI.text = " ";
        } */
    }
}

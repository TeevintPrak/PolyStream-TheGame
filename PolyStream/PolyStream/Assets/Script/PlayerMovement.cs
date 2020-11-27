using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject player;
    public Transform playerT;
    public Text score;
    PlayerControls controls;

    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    public float boostedForce;
    public float brakingForce;
    public float jumpForce;
    public float fwdJumpForce;
    public float cooldownTime;
    float nextJumpTime = 0;
    float barCDTime = 0.5f;
    float nextCDTime = 0;

    public float explosionForce;
    public float explosionRadius;
    public float explosionsUpForce;

    void Awake()
    {
        controls = new PlayerControls();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.drag = 2f;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Keyboard.current.wKey.isPressed)
        {
            rb.AddForce(0, 0, boostedForce * Time.deltaTime);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            rb.AddForce(0, 0, -brakingForce * Time.deltaTime);
        }
        if (rb.position.y <= -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    public void Left()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void Right()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void Boost()
    {
        rb.AddForce(0, 0, boostedForce * Time.deltaTime);
    }

    public void Brake()
    {
        rb.AddForce(0, 0, -brakingForce * Time.deltaTime);
    }

    public void Jump()
    {
        if (Time.time > nextJumpTime)
        {
            FindObjectOfType<CoolDown_Bar>().ResetBar();
            rb.drag = 0f;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
            rb.AddForce(0, -jumpForce * 18, 0);
            nextJumpTime = Time.time + cooldownTime;
            nextCDTime = Time.time + barCDTime;
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (Time.time > nextJumpTime)
            {
                FindObjectOfType<CoolDown_Bar>().ResetBar();
                rb.drag = 0f;
                rb.constraints = RigidbodyConstraints.FreezeRotation;
                rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
                rb.AddForce(0, -jumpForce * 18, 0);
                nextJumpTime = Time.time + cooldownTime;
                nextCDTime = Time.time + barCDTime;
            }
        }
        else if(Time.time > nextCDTime && Time.time < nextJumpTime)
        { 
            FindObjectOfType<CoolDown_Bar>().CoolDownBar();
        }
    }
}

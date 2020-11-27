using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public bool collided = false;
    // Update is called once per frame
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles" || collisionInfo.collider.tag == "QObstacles")
        {
            FindObjectOfType<GameManager>().DeathCounter();
            FindObjectOfType<Explosion_Code>().Explode();
            FindObjectOfType<GameManager>().InvokeGameOver();
        }
    }
    
}

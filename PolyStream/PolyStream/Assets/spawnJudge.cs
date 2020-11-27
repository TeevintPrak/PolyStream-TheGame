/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnJudge : MonoBehaviour
{
    static bool spawn = true;
    MeshRenderer mesh;
    CapsuleCollider colliderCAP;
    // Start is called before the first frame update
    int currentSceneID;
    void Start()
    {
        currentSceneID = SceneManager.GetActiveScene().buildIndex;
        mesh = GetComponent<MeshRenderer>();
        colliderCAP = GetComponent<CapsuleCollider>();
    }
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player")
        {
            mesh.enabled = false;
            colliderCAP.enabled = false;
            FindObjectOfType<GameManager>().AddCoins(1);
        }
    }
} */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnJudge : MonoBehaviour
{
    MeshRenderer mesh;
    CapsuleCollider colliderCAP;
    // Start is called before the first frame update
    int currentSceneID;
    //int collected; //0 is false , 1 is true

    void Start()
    {
        currentSceneID = SceneManager.GetActiveScene().buildIndex;
        mesh = GetComponent<MeshRenderer>();
        colliderCAP = GetComponent<CapsuleCollider>();
        //JudgeSpawn();
    }

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddCoins(1);
            mesh.enabled = false;
            colliderCAP.enabled = false;
            //collected = 1;
            //PlayerPrefs.SetInt("collected1", collected);
            //Debug.Log("collected is also" + collected);
        }
    }

 /*   public void JudgeSpawn()
    {
        bool spawn = GameManager.levelComplete;
        Debug.Log("collected is" + collected);
        if (PlayerPrefs.GetInt("collected1", collected) == 1)
        {
            if (spawn)
            {
                Debug.Log("spawn is also" + spawn);
                mesh.enabled = true;
                colliderCAP.enabled = true;
            }
            else
            {
                Debug.Log("spawn is also" + spawn);
                mesh.enabled = false;
                colliderCAP.enabled = false;
            }
        }
    } */
}

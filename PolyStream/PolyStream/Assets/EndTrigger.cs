using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement pm; 

    public void OnTriggerEnter(Collider Player)
    {
        pm.enabled = false;
        gameManager.CompleteLevelUI();
    }
}

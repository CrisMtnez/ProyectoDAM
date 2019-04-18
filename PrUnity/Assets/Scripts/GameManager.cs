using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool ended = false;
    public GameObject winPanel;
    public PlayerMov playerMovement;

    public void Start()
    {

    }

    public void GameOver()
    {
        if (!ended)
        {
            ended = true;
            Invoke("Restart", 1f);
        }            
    }

    public void YouWin()
    {
        playerMovement.alive = false;
        playerMovement.kip.freezeRotation = true;
        playerMovement.kip.constraints = RigidbodyConstraints.FreezePositionY;
        playerMovement.kip.constraints = RigidbodyConstraints.FreezePositionX;
        playerMovement.kip.constraints = RigidbodyConstraints.FreezePositionZ;
        winPanel.SetActive(true);        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void FixedUpdate()
    {
        
        
    }
}

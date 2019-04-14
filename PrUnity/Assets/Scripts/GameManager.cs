using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool ended = false;
    public GameEnds ge;

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

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

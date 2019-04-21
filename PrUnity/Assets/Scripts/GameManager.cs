using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool ended = false;
    public GameObject winPanel;
    public GameObject helpPanel;
    public PlayerMov playerMovement;
    public GameObject helpButton;
    public GameObject time;
    public static bool PLAYING = false;
    public bool firstStep = false;

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
        if (Input.anyKey & PLAYING & !firstStep)
        {
            firstStep = true;
            helpButton.SetActive(true);
            time.SetActive(true);
        }

        if (PLAYING && (Input.GetKey(KeyCode.H) || Input.GetKey(KeyCode.P)))
            ShowHelp();
        //if (!PLAYING && (Input.GetKey(KeyCode.H) || Input.GetKey(KeyCode.P)))     //no funciona bien
        //    HideHelp();
        if (PLAYING && Input.GetKey(KeyCode.Q))
            QuitGame();
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(1);
        PLAYING = false;
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }

    public void ShowHelp()
    {        
        helpPanel.SetActive(true);
        PLAYING = false;
        //tiempo y coches en pausa, gallina quieta
        //botones help con los comandos, quit para volver al menu y back para volver al juego
    }
    //public void HideHelp()        //no funciona
    //{
    //    helpPanel.SetActive(false);
    //    PLAYING = true;
    //}
}

using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour
{
    public bool ended = false;
    public GameObject winPanel;
    public GameObject helpPanel;
    public PlayerMov playerMovement;
    public GameObject helpButton;
    public GameObject time;
    public GameObject tryAgainPanel;
    public static bool PLAYING = false;
    public bool firstStep = false;
    public GameObject quicklyText;
    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip clickSound;
    public AudioClip jumpSound;
    public AudioClip trafficSound1;
    public AudioClip trafficSound2;
    public AudioClip trafficSound3;
    public AudioClip horn;
    public AudioClip crashSound;
    public AudioClip normalMusic;
    public static bool jumpSoundPlayed = false;
    public static bool crashSoundPlayed = false;
    private float volLowRange = .2f;
    private float volHighRange = 0.6f;

    public void Start()
    {
    }

    public void PlayMusic()
    {
        if (SoundButton.SOUNDSON && !musicSource.isPlaying)
            musicSource.Play();
        else if (!SoundButton.SOUNDSON && musicSource.isPlaying)
            musicSource.Pause();
    }

    public void TrafficSounds()
    {
        if (SoundButton.SOUNDSON)
        {
            float vol = Random.Range(volLowRange, volHighRange);
            audioSource.PlayOneShot(trafficSound1, vol);
            audioSource.PlayOneShot(trafficSound2, 0.4f);
            audioSource.PlayOneShot(trafficSound3, vol);
            audioSource.PlayOneShot(horn, 0.7f);
        }
    }

    public void ClickSound()
    {
        if (SoundButton.SOUNDSON)
            audioSource.PlayOneShot(clickSound, 0.4f);
    }

    public void JumpSound()
    {
        if (SoundButton.SOUNDSON)
        {
            if (!jumpSoundPlayed)
                audioSource.PlayOneShot(jumpSound, 0.8f);
        }
    }

    public void CrashSound()
    {
        if (SoundButton.SOUNDSON)
        {
            if (!crashSoundPlayed)
                audioSource.PlayOneShot(crashSound, 2f);
        }
    }

    public void GameOver()
    {
        quicklyText.SetActive(false);
        helpPanel.SetActive(false);
        if (!ended)
        {
            ended = true;
            Invoke("RestartPanel", 1f);
        }            
    }

    public void YouWin()
    {
        quicklyText.SetActive(false);
        playerMovement.alive = false;
        playerMovement.kip.freezeRotation = true;
        playerMovement.kip.constraints = RigidbodyConstraints.FreezePositionY;
        playerMovement.kip.constraints = RigidbodyConstraints.FreezePositionX;
        playerMovement.kip.constraints = RigidbodyConstraints.FreezePositionZ;
        winPanel.SetActive(true);
        Invoke("ShowCredits", 9f);
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene(2);
        GameManager.PLAYING = false;
    }

    public void RestartPanel()
    {
        quicklyText.SetActive(false);
        helpPanel.SetActive(false);
        tryAgainPanel.SetActive(true);        
    }

    public void FixedUpdate()
    {
        PlayMusic();
        if (PLAYING)
            TrafficSounds();
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
        {
            PauseGame();
            QuitGame();
        }           
    }

    public void QuitGame()
    {
        PauseGame();
        FindObjectOfType<QuitButton>().OnPlaying();        
    }

    public void PauseGame()
    {
        PLAYING = false;
        playerMovement.alive = false;
    }

    public void ResumeGame()
    {
        crashSoundPlayed = false;
        PLAYING = true;
        playerMovement.alive = true;
    }

    public void ShowHelp()
    {        
        helpPanel.SetActive(true);
        PauseGame();
    }

    public void HideHelp()        
    {
        helpPanel.SetActive(false);
        ResumeGame();        
    }
}

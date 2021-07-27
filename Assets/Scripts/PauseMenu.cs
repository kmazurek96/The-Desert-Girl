using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (GamePaused)
            {
                Resume();
            }
            else
                Pause();


        }
    }

    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void onResume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void onMenu()
    {
        SceneManager.LoadScene("MainMenu");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //PlayerPrefs.DeleteKey("Score");
        //coinsValue = 0;
        Time.timeScale = 1f;
    }

    public void onQuit()
    {
        Application.Quit();
    }
}

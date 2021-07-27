using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{

    public GameObject music;

    private void Start()
    {
        
        
    }
    // Start is called before the first frame update
    public void ToGame()
    {
        music = GameObject.Find("cron_audio_8-bit_modern02");
        if (music) Destroy(music);
        SceneManager.LoadScene("mapa1");
        
    }

    public void ToQuit()
    {
        Application.Quit();
    }
}

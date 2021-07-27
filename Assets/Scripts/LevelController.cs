using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update

    private int nextSceneToLoad;
    private CoinsScore cs;
    private PlayerHealthScript PHS;
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
           // saveScore();
            //saveHealth();
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }

    //public void saveScore()
   // {
    //    PlayerPrefs.SetInt("Score", CoinsScore.coinsValue);
   // }
    
   // public void saveHealth()
   // {
   //     PlayerPrefs.SetInt("Health", PlayerHealthScript.actuallyPlayerHealth);
  //  }
}

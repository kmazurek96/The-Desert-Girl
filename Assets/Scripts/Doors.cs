using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    // Start is called before the first frame update
    private int nextSceneToLoad;
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.keys == 1)
        {
            SceneManager.LoadScene(nextSceneToLoad);
            GameManager.keys = 0;


        }
    }
}

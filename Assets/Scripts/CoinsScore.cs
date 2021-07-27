using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CoinsScore : MonoBehaviour
{
    public static int coinsValue; // coinsValue = 0;?
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        if (SceneManager.GetActiveScene().name == "mapa1")
        {
           // PlayerPrefs.DeleteKey("Score");
            coinsValue = 0;
        }
        /* if (PlayerPrefs.HasKey("Score"))
         {
             if (Application.loadedLevel == 0)
             {

             }

             else
             {
                 coinsValue = PlayerPrefs.GetInt("Score");
             }
         }
         */
        // coinsValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = coinsValue.ToString();
    }

    
}

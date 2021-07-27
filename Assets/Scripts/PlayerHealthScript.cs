using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthScript : MonoBehaviour
{
    public int playerHealth;
    public static int actuallyPlayerHealth = 3;
    Text HealthText;

    public void Start()
    {
        if (SceneManager.GetActiveScene().name == "mapa1")
        {
        actuallyPlayerHealth = 3;
            }
        HealthText = GetComponent<Text>();



    }

    void Update()
    {
        playerHealth = actuallyPlayerHealth;
        HealthText.text = actuallyPlayerHealth.ToString();
    }
    public void UpdateHealth()
    {
        actuallyPlayerHealth = playerHealth;
        //HealthText.text = playerHealth.ToString();

    }
    }

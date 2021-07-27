using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScreen : MonoBehaviour
{

    Text endScore;
    // Start is called before the first frame update
    void Start()
    {
        endScore = GetComponent<Text>();
        endScore.text = CoinsScore.coinsValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

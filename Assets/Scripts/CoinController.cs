using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(this.gameObject);
        SoundManagerScript.PlaySound("coin");
        Debug.Log("Tak");
        CoinsScore.coinsValue += 1;
    }
}

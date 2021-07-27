using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
     //GameManager GM;
    public int keyCount;
    

    // Start is called before the first frame update
    void Start()
    {
       // GM = GameObject.Find("GM").GetComponent<GameManager>();
        //GM = gameObject.GetComponent<GameManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameManager.keys += 1;
        Destroy(this.gameObject);
       
        
    }
}

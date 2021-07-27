using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    public GameObject hero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hero = GameObject.Find("Hero");
        this.transform.SetParent(hero.transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("monster"))
        {
            Destroy(collision.transform.parent.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenPlatfrom : MonoBehaviour
{
    Rigidbody2D rb;
    private Object islandRef;
    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = gameObject.transform.position;
        islandRef = Resources.Load("Fallen_Island");
        rb = GetComponent<Rigidbody2D>();
    }
       

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Invoke("DropPlatform", 0.5f);
            
            Invoke("Respawn", 5);
        }
    }
    void DropPlatform()
    {
        rb.isKinematic = false;
        
    }

    void Respawn()
    {
        GameObject islandClone = (GameObject)Instantiate(islandRef);
        islandClone.transform.position = StartPosition;
        Destroy(gameObject, 2f);
    }
}


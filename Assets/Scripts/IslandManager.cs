using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandManager : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] private MovingPlatform MovingPlatform;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        collision.transform.parent = transform;
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.transform.parent = null;
    }
}

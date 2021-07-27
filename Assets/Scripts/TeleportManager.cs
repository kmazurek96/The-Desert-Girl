using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{

    [SerializeField] GameObject Hero;
    [SerializeField] GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        
         
            {
                collision.transform.position = new Vector2(Target.transform.position.x-0.05f, Target.transform.position.y+1);
            }
        
    }
}

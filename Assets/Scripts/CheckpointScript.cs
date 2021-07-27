using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    StartPosition startPosition;
    void Start()
    {
        startPosition = GameObject.Find("StartPositionManager").GetComponent<StartPosition>();
    }
    public  void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            startPosition.UpdateRestartPoint(this.gameObject.transform);
        }
    }
}

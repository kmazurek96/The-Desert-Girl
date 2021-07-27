using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Vector3 pktA;
    private Vector3 pktB;
    public float speed;
    [SerializeField] private Transform childTransform;
    [SerializeField] private Transform pktBTransform;
    private Vector3 next;





    // Start is called before the first frame update
    void Start()
    {
        pktA = childTransform.localPosition;
        pktB = pktBTransform.localPosition;
        next = pktB;

    }

    // Update is called once per frame
    void Update()
    {
        nextPosition();
    }

    void nextPosition()
    {

        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, next, speed * Time.deltaTime);

        if (Vector3.Distance(childTransform.localPosition, next) <= 0.1)
        {
            Changedirection();
        }

    }
    
    void Changedirection()
    {
        next = next != pktA ? pktA : pktB;
    }


}



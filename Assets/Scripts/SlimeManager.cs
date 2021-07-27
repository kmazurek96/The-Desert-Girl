using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeManager : MonoBehaviour


{
    private Vector3 pktA;
    private Vector3 pktB;
    public float speed;
    [SerializeField] private Transform childTransform;
    [SerializeField] private Transform pktBTransform;
    [SerializeField] private GameObject slime;

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
            SlimeFlip();
        }

    }

    void Changedirection()
    {
        next = next != pktA ? pktA : pktB;
    }


void SlimeFlip()
        {
            Vector3 slimeScale = slime.transform.localScale;
            slimeScale.x *= -1;
            slime.transform.localScale = slimeScale;

        }
    }



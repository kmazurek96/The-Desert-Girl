using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{ 

    public GameObject Hero;
    public float smooth;

    private Vector3 currVelocity;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 newCameraPostion = new Vector3(Hero.transform.position.x , transform.position.y, transform.position.z); // działa też od pozycji
        // transform.position = newCameraPostion; // działa
       // gameObject.transform.localPosition = new Vector3(Hero.transform.position.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z); //też od pozycji ale nie działa jak jest dzieckiem
        transform.position = Vector3.SmoothDamp(transform.position, newCameraPostion, ref currVelocity, smooth);
    }
}

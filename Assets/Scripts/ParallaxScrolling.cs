using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour

    

{
    // Start is called before the first frame update
    public float parallaxFactor;
    public Transform cameraTransform;

    private Vector3 prevCameraPostition;
    private Vector3 deltaCamera;

    void Start()
    {
        prevCameraPostition = cameraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        deltaCamera = cameraTransform.position - prevCameraPostition;
        Vector3 parralaxPosition = new Vector3(transform.position.x + (deltaCamera.x * parallaxFactor), transform.position.y, transform.position.z);
        transform.position = parralaxPosition;
        prevCameraPostition = cameraTransform.position;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWidth : MonoBehaviour
{
    public float sceneWidth = 10;

    Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float unitsPerPixel = sceneWidth / Screen.width;

        float desiredHalfHeight = 0.8f * unitsPerPixel * Screen.height;

        _camera.orthographicSize = desiredHalfHeight;
    }
}

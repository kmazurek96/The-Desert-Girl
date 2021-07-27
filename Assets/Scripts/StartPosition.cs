using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour

{
    public PlayerBehaviour playerBehaviour;

    public void UpdateRestartPoint(Transform newTransform)
    {
        playerBehaviour.startPoint = newTransform;
    }
}
